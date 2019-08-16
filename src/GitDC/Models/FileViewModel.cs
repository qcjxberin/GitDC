using LibGit2Sharp;

namespace GitDC.Models
{
    public class FileViewModel
    {
        public TreeEntryTargetType EntryType { get; set; }

        public Repository Repository { get; set; }

        public GitObject Object { get; set; }

        public string SHA1 => Object.Sha;

        public ObjectType Type => Repository.ObjectDatabase.RetrieveObjectMetadata(Object.Id).Type;

        public string Path { get; set; }

        public string Name { get; set; }

        public Commit Commit { get; set; }

        protected internal FileViewModel(Repository repo, string path, string name, GitObject obj)
        {
            Repository = repo;
            Path = path;
            Name = name;
            Object = obj;
        }

        protected internal FileViewModel(Repository repo, string path, string name, GitObject obj, TreeEntryTargetType entryType)
        {
            Repository = repo;
            Path = path;
            Name = name;
            Object = obj;
            EntryType = entryType;
        }

        protected internal FileViewModel(Repository repo, string path, string name, GitObject obj, Commit commit)
        {
            Repository = repo;
            Path = path;
            Name = name;
            Object = obj;
            Commit = commit;
        }

        public static FileViewModel FromGitObject(Repository repo, string path, string name, GitObject obj, TreeEntryTargetType EntryType)
        {
            switch (repo.ObjectDatabase.RetrieveObjectMetadata(obj.Id).Type)
            {
                case ObjectType.Blob:
                    return new BlobModel(repo, path, name, (Blob)obj, EntryType);

                case ObjectType.Tree:
                    return new TreeModel(repo, path, name, (Tree)obj, EntryType);

                default:
                    return null;
            }
        }
    }

    public class FileViewModel<TObject> : FileViewModel where TObject : GitObject
    {
        protected new TObject Object => (TObject)base.Object;

        protected internal FileViewModel(Repository repo, string path, string name, TObject obj) : base(repo, path, name, obj) { }

        protected internal FileViewModel(Repository repo, string path, string name, TObject obj, Commit commit) : base(repo, path, name, obj, commit) { }

        protected internal FileViewModel(Repository repo, string path, string name, TObject obj, TreeEntryTargetType EntryType) : base(repo, path, name, obj, EntryType) { }
    }
}
