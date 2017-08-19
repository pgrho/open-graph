namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents an web application attached to the graph.
    /// </summary>
    public sealed partial class Weblink : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Weblink" /> class.
        /// </summary>
        public Weblink()
            : this("al")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weblink" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal Weblink(string path)
            : base(path)
        {
        }
    }
}