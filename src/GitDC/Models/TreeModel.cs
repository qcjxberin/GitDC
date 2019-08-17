using Ding.Helpers;
using Ding.Log;
using GitDC.Base;
using LibGit2Sharp;
using System.Collections.Generic;
using System.Linq;

namespace GitDC.Models
{
    public class TreeModel : FileViewModel<Tree>
    {
        public string Parent { get; set; }

        public IEnumerable<FileViewModel> Children
        {
            get
            {
                //XTrace.UseConsole();

                var result = Object.Select(d => FromGitObject(Repository, d.Path, d.Name, d.Target, d.TargetType))
                    .OrderBy(s => s.EntryType == TreeEntryTargetType.Blob)
                    .ThenBy(s => s.Name, new StringLogicalComparer());

                //var ancestors = Repository.Commits
                //    .QueryBy(new CommitFilter { IncludeReachableFrom = Commit, SortBy = CommitSortStrategies.Topological });



                //foreach (var item in result)
                //{
                //    foreach (var ancestor in ancestors)
                //    {
                //        var ancestorEntry = ancestor[item.Path];
                //        if (ancestorEntry != null && ancestorEntry.Target.Sha == item.Object.Sha)
                //        {
                //            XTrace.WriteLine($"测试测试测试测试测试2:{ancestorEntry.ToJson()}_{ancestor.Committer.When}");
                //            //break;
                //        }
                //    }
                //    XTrace.WriteLine($"测试测试测试测试测试1:{item.Name}_{item.Path}_{item.Object.Sha}");
                //}

                return result;
            }
        }

        public TreeModel(Repository repo, string path, string name, Tree obj, string parent = null) : base(repo, path, name, obj)
        {
            Parent = parent;
        }

        public TreeModel(Repository repo, string path, string name, Tree obj, Commit commit, string parent = null) : base(repo, path, name, obj, commit)
        {
            Parent = parent;
        }

        public TreeModel(Repository repo, string path, string name, Tree obj, TreeEntryTargetType EntryType, string parent = null) : base(repo, path, name, obj, EntryType)
        {
            Parent = parent;
        }
    }
}
