using Ding.Log;
using GitDC.Common;
using GitDC.Extensions;
using LibGit2Sharp;
using System.Diagnostics.Contracts;
using System.Linq;

namespace GitDC.Git.Cache
{
    public abstract class GitCache
    {
        protected readonly string repoId;
        protected readonly Repository repo;
        protected readonly string repoPath;

        protected bool resultDone;
        protected string cacheKey;
        
        public GitCache(string repoId, Repository repo)
        {
            Contract.Requires(repoId != null);
            Contract.Requires(repo != null);

            this.repoId = repoId;
            this.repo = repo;
            this.repoPath = repo.Info.Path;
        }

        protected abstract string GetCacheKey();

        /// <summary>
        /// 获取Git缓存Key
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="keys"></param>
        /// <returns></returns>
        protected string GetCacheKey(string Name, params object[] keys)
        {
            Contract.Requires(keys != null);
            Contract.Requires(keys.Length > 0);
            Contract.Requires(keys.All(s => s != null));

            var key = CacheKeys.REPOSITORIES + Name + string.Concat(keys);
            cacheKey = key.CalcSha();
            return cacheKey;
        }
    }
}
