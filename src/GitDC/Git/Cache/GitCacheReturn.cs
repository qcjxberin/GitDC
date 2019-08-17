namespace GitDC.Git.Cache
{
    public struct GitCacheReturn<T>
    {
        public T Value { get; set; }

        public bool Done { get; set; }
    }
}
