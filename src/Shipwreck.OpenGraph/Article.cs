namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents an article on a website.
    /// </summary>
    public sealed partial class Article : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Article" /> class.
        /// </summary>
        public Article()
            : this("article")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Article" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal Article(string path)
            : base(path)
        {
        }
    }
}