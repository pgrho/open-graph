namespace Shipwreck.OpenGraph
{
    public sealed partial class Article : GraphObject
    {
        public Article()
            : this("article")
        {
        }

        internal Article(string path)
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