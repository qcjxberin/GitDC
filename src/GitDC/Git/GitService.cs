using Ding.Helpers;
using Ding.Log;
using GitDC.Base;
using GitDC.Common;
using GitDC.Extensions;
using GitDC.Git.Cache;
using GitDC.Models;
using LibGit2Sharp;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDC.Git
{
    public class GitService : IDisposable
    {
        public const string UnknowString = "<Unknow>";

        private readonly Repository _repository;
        private readonly string _repositoryPath;
        private readonly string _repoId = null;
        private readonly Lazy<Encoding> _i18n;
        private bool _disposed;

        public Encoding I18n { get { return _i18n.Value; } }
        public string Name { get; private set; }

        public GitService(string name)
        {
            var info = GetDirectoryInfo(name);
            _repositoryPath = info.FullName;
            _repoId = Name = info.Name;

            if (!Repository.IsValid(_repositoryPath))
            {
                CreateRepository(name);
            }

            _repository = new Repository(_repositoryPath);
            _i18n = new Lazy<Encoding>(() =>
            {
                var entry = _repository.Config.Get<string>("i18n.commitEncoding");
                return entry == null
                    ? null
                    : CpToEncoding(entry.Value);
            });
        }

        #region Repository Browser
        public async Task<TreesModel> GetTree(string path)
        {
            var isEmptyPath = string.IsNullOrEmpty(path);
            string referenceName;
            var commit = GetCommitByPath(ref path, out referenceName);
            if (commit == null)
            {
                if (isEmptyPath)
                {
                    var branch = _repository.Branches["master"]
                        ?? _repository.Branches.FirstOrDefault();
                    return new TreesModel
                    {
                        ReferenceName = branch == null ? "HEAD" : branch.FriendlyName,
                    };
                }
                return null;
            }

            var model = new TreesModel
            {
                ReferenceName = referenceName,
                Path = string.IsNullOrEmpty(path) ? "" : path,
                Commit = new CommitModel
                {
                    Sha = commit.Sha,
                    Author = commit.Author,
                    Committer = commit.Committer,
                    CommitMessageShort = commit.MessageShort.RepetitionIfEmpty(UnknowString),
                    Parents = commit.Parents.Select(s => s.Sha).ToArray()
                },
            };

            var tree = string.IsNullOrEmpty(path)
                ? commit.Tree
                : commit[path] == null
                    ? null
                    : commit[path].Target as Tree;
            if (tree == null)
                return null;

            model.RepositoryName = _repoId;

            var CacheSummary = new SummaryCache(_repoId, _repository, commit, tree);
            var result = await CacheSummary.GetCache();

            var entries = (from entry in tree
                           join item in result on entry.Name equals item.Name into g
                           from item in g
                           select new TreeEntryModel
                           {
                               Name = entry.Name,
                               Path = entry.Path.Replace('\\', '/'),
                               Commit = new CommitModel
                               {
                                   Sha = item.CommitSha,
                                   CommitMessageShort = item.MessageShort,
                                   Author = CreateSafeSignature(item.AuthorName, item.AuthorEmail, item.AuthorWhen),
                                   Committer = CreateSafeSignature(item.CommitterName, item.CommitterEmail, item.CommitterWhen),
                               },
                               Sha = item.CommitSha,
                               EntryType = entry.TargetType,
                           })
                           .OrderBy(s => s.EntryType == TreeEntryTargetType.Blob)
                           .ThenBy(s => s.Name, new StringLogicalComparer())
                           .ToList();

            model.Entries = entries;
            model.Readme = entries.FirstOrDefault(s => s.EntryType == TreeEntryTargetType.Blob
                && (string.Equals(s.Name, "readme", StringComparison.OrdinalIgnoreCase)
                    //|| string.Equals(s.Name, "readme.txt", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(s.Name, "readme.md", StringComparison.OrdinalIgnoreCase)));

            if (model.Readme != null)
            {
                var data = ((Blob)tree[model.Readme.Name].Target).GetContentStream().ToBytes();
                var encoding = FileHelper.DetectEncoding(data, CpToEncoding(commit.Encoding), _i18n.Value);
                if (encoding == null)
                {
                    model.Readme.BlobType = BlobType.Binary;
                }
                else
                {
                    model.Readme.BlobType = model.Readme.Name.EndsWith(".md", StringComparison.OrdinalIgnoreCase)
                        ? BlobType.MarkDown
                        : BlobType.Text;
                    model.Readme.TextContent = FileHelper.ReadToEnd(data, encoding);
                    model.Readme.TextBrush = "no-highlight";
                }
            }

            model.BranchSelector = GetBranchSelectorModel(referenceName, commit.Sha, path);
            model.PathBar = new PathBarModel
            {
                Name = Name,
                Action = "Tree",
                Path = path,
                ReferenceName = referenceName,
                ReferenceSha = commit.Sha,
                HideLastSlash = false,
            };

            if (model.IsRoot)
            {
                var CacheScope = new ScopeCache(_repoId, _repository, commit);
                model.Scope = await CacheScope.GetCache();
            }

            return model;
        }
        #endregion

        #region Private Methods
        private BranchSelectorModel GetBranchSelectorModel(string referenceName, string refer, string path)
        {
            var model = new BranchSelectorModel
            {
                Branches = _repository.Branches.Select(s => s.FriendlyName).OrderBy(s => s, new StringLogicalComparer()).ToList(),
                Tags = _repository.Tags.Select(s => s.FriendlyName).OrderByDescending(s => s, new StringLogicalComparer()).ToList(),
                Current = referenceName ?? refer.ToShortSha(),
                Path = path,
            };
            model.CurrentIsBranch = model.Branches.Contains(referenceName) || !model.Tags.Contains(referenceName);

            return model;
        }

        private Commit GetCommitByPath(ref string path, out string referenceName)
        {
            referenceName = null;

            if (string.IsNullOrEmpty(path))
            {
                referenceName = _repository.Head.FriendlyName;
                path = "";
                return _repository.Head.Tip;
            }

            path = path + "/";
            var p = path;
            var branch = _repository.Branches.FirstOrDefault(s => p.StartsWith(s.FriendlyName + "/"));
            if (branch != null && branch.Tip != null)
            {
                referenceName = branch.FriendlyName;
                path = path.Substring(referenceName.Length).Trim('/');
                return branch.Tip;
            }

            var tag = _repository.Tags.FirstOrDefault(s => p.StartsWith(s.FriendlyName + "/"));
            if (tag != null && tag.Target is Commit)
            {
                referenceName = tag.FriendlyName;
                path = path.Substring(referenceName.Length).Trim('/');
                return (Commit)tag.Target;
            }

            var index = path.IndexOf('/');
            var commit = _repository.Lookup<Commit>(path.Substring(0, index));
            path = path.Substring(index + 1).Trim('/');
            return commit;
        }

        private Encoding CpToEncoding(string encoding)
        {
            try
            {
                if (encoding.StartsWith("cp", StringComparison.OrdinalIgnoreCase))
                    return Encoding.GetEncoding(int.Parse(encoding.Substring(2)));

                return Encoding.GetEncoding(encoding);
            }
            catch
            {
                return null;
            }
        }

        private Signature CreateSafeSignature(string name, string email, DateTimeOffset when)
        {
            return new Signature(name.RepetitionIfEmpty(UnknowString), email, when);
        }

        #endregion

        #region Static Methods

        public static bool CreateRepository(string name, string remoteUrl = null)
        {
            var path = Path.Combine(SiteSetting.Current.GitConfig.RepositoryPath, name);
            try
            {
                using (var repo = new Repository(Repository.Init(path, true)))
                {
                    repo.Config.Set("core.logallrefupdates", true);
                    if (remoteUrl != null)
                    {
                        repo.Network.Remotes.Add("origin", remoteUrl, "+refs/*:refs/*");
                    }
                }
                return true;
            }
            catch
            {
                try
                {
                    Directory.Delete(path, true);
                }
                catch { }
                return false;
            }
        }

        private static DirectoryInfo GetDirectoryInfo(string project)
        {
            return new DirectoryInfo(Path.Combine(SiteSetting.Current.GitConfig.RepositoryPath, project));
        }

        #endregion

        #region IDisposable Members
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_repository != null)
                    {
                        _repository.Dispose();
                    }
                }

                _disposed = true;
            }
        }

        ~GitService()
        {
            Dispose(false);
        }
        #endregion

    }
}
