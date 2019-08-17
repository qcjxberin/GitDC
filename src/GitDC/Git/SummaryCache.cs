using Ding.Helpers;
using Ding.Log;
using EasyCaching.Core;
using GitDC.Base;
using GitDC.Extensions;
using GitDC.Git.Cache;
using LibGit2Sharp;
using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace GitDC.Git
{
    public class SummaryCache: GitCache
    {
        private readonly Commit commit;
        private readonly Tree tree;

        protected RevisionSummaryCacheItem[] result;

        public SummaryCache(string repoId, Repository repo, Commit commit, Tree tree) : base(repoId, repo)
        {
            Contract.Requires(commit != null);
            Contract.Requires(tree != null);

            this.commit = commit;
            this.tree = tree;
        }

        protected override string GetCacheKey()
        {
            return GetCacheKey("SummaryCache", commit.Id, tree.Id);
        }

        protected void Init()
        {
            result = tree
                .OrderBy(s => s.TargetType == TreeEntryTargetType.Blob)
                .ThenBy(s => s.Name, new StringLogicalComparer())
                .Select(s => new RevisionSummaryCacheItem
                {
                    Name = s.Name,
                    Path = s.Path.Replace('\\', '/'),
                    TargetSha = s.Target.Sha,
                    MessageShort = "Loading...",
                    AuthorEmail = "Loading...",
                    AuthorName = "Loading...",
                    CommitterEmail = "Loading...",
                    CommitterName = "Loading...",
                })
                .ToArray();
        }

        protected void Calculate()
        {
            Init();
            using (var repo = new Repository(this.repoPath))
            {
                var ancestors = repo.Commits
                    .QueryBy(new CommitFilter { IncludeReachableFrom = commit, SortBy = CommitSortStrategies.Topological });

                // null, continue search current reference
                // true, have found, done
                // false, search has been interrupted, but waiting for next match
                var status = new bool?[result.Length];
                var done = result.Length;
                Commit lastCommit = null;
                foreach (var ancestor in ancestors)
                {
                    for (var index = 0; index < result.Length; index++)
                    {
                        if (status[index] == true)
                            continue;
                        var item = result[index];
                        var ancestorEntry = ancestor[item.Path];
                        if (ancestorEntry != null && ancestorEntry.Target.Sha == item.TargetSha)
                        {
                            item.CommitSha = ancestor.Sha;
                            item.MessageShort = ancestor.MessageShort.RepetitionIfEmpty(GitService.UnknowString);
                            item.AuthorEmail = ancestor.Author.Email;
                            item.AuthorName = ancestor.Author.Name;
                            item.AuthorWhen = ancestor.Author.When;
                            item.CommitterEmail = ancestor.Committer.Email;
                            item.CommitterName = ancestor.Committer.Name;
                            item.CommitterWhen = ancestor.Committer.When;

                            status[index] = null;
                        }
                        else if (status[index] == null)
                        {
                            var over = true;
                            foreach (var parent in lastCommit.Parents) // Backtracking
                            {
                                if (parent.Sha == ancestor.Sha)
                                    continue;
                                var entry = parent[item.Path];
                                if (entry != null && entry.Target.Sha == item.TargetSha)
                                {
                                    over = false;
                                    break;
                                }
                            }
                            status[index] = over;
                            if (over)
                                done--;
                        }
                    }
                    if (done == 0)
                        break;
                    lastCommit = ancestor;
                }
            }
            resultDone = true;
        }

        public async Task<RevisionSummaryCacheItem[]> GetCache()
        {
            var cache = Ioc.Create<IEasyCachingProviderFactory>().GetCachingProvider("redis1");
            var CacheKey = GetCacheKey();
            if (await cache.ExistsAsync(CacheKey))
            {
                result = (await cache.GetAsync<RevisionSummaryCacheItem[]>(CacheKey)).Value;
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
