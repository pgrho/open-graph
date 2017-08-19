namespace Shipwreck.OpenGraph
{
    public sealed partial class Book : GraphObject
    {
        public Book()
            : this("book")
        {
        }

        internal Book(string path)
            : base(path)
        {
        }

        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "author", out matched))
            {
                return new Profile(Path + ":author");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
}