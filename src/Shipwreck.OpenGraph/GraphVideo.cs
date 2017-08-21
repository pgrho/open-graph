namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents an video resource that can attached to other <see cref="GraphObject"/>.
    /// </summary>
    public sealed partial class GraphVideo : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphVideo" /> class.
        /// </summary>
        public GraphVideo()
            : this(new PropertyPath(NamespaceCollection.OpenGraph, "video"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphVideo" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal GraphVideo(PropertyPath path)
            : base(path)
        {
        }
    }
}