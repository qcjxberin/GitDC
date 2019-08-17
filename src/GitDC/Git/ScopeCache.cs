using Ding.Helpers;
using EasyCaching.Core;
using GitDC.Extensions;
using GitDC.Git.Cache;
using GitDC.Models;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace GitDC.Git
{
    public class ScopeCache : GitCache
    {
        protected RepositoryScope result;

        private readonly Commit commit;
        private readonly string path;
        private readonly bool pathExist;

        public ScopeCache(string repoId, Repository repo, Commit commit, string path = "") : base(repoId, repo)
        {
            Contract.Requires(commit != null);

            this.commit = commit;
            this.path = path;
            this.pathExist = commit[path] != null;
        }

        protected override string GetCacheKey()
        {
            return GetCacheKey("ScopeCache", commit.Sha, path);
        }

        protected void Init()
        {
            result = new RepositoryScope
            {
                Commits = 0,
                Contributors = 0,
                Branches = repo.Branches.Count(),
                Tags = repo.Tags.Count(),
            };
        }

        protected void Calculate()
        {
            Init();
            using (var repo = new Repository(this.repoPath))
            {
                var ancestors = pathExist
                    ? repo.Commits.QueryBy(new CommitFilter { IncludeReachableFrom = commit }).PathFilter(path)
                    : repo.Commits.QueryBy(new CommitFilter { IncludeReachableFrom = commit });

                var set = new HashSet<string>();
                foreach (var ancestor in ancestors)
                {
                    result.Commits++;
                    if (set.Add(ancestor.Author.ToString()))
                        result.Contributors++;
                }
            }
            resultDone = true;
        }

        public async Task<RepositoryScope> GetCache()
        {
            var cache = Ioc.Create<IEasyCachingProviderFactory>().GetCachingProvider("redis1");
            var CacheKey = GetCacheKey();
            if (await cache.ExistsAsync(CacheKey))
            {
                result = (await cache.GetAsync<RepositoryScope>(CacheKey)).Value;
            }
            else
            {
                Calculate();
                cache.Set(CacheKey, result, TimeSpan.FromDays(7));
            }
            return result;
        }
    }
}
