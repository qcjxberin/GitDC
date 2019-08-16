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
                return Object.Select(d => FromGitObject(Repository, d.Path, d.Name, d.Target, d.TargetType))
                    .OrderBy(s => s.EntryType == TreeEntryTargetType.Blob)
                    .ThenBy(s => s.Name, new StringLogicalComparer());
            }
        }

        public TreeModel(Repository repo, string path, string name, Tree obj, string parent = null) : base(repo, path, name, obj)
        {
            Parent = parent;
        }

        public TreeModel(Repository repo, string path, string name, Tree obj, TreeEntryTargetType EntryType, string parent = null) : base(repo, path, name, obj, EntryType)
        {
            Parent = parent;
        }
    }
}
