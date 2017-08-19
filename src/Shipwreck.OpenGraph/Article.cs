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
    }
}