namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents an image resource that can attached to other <see cref="GraphObject"/>.
    /// </summary>
    public sealed partial class GraphImage : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphImage" /> class.
        /// </summary>
        public GraphImage()
            : this(new PropertyName(NamespaceCollection.OpenGraph, "image"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphImage" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal GraphImage(PropertyName path)
            : base(path)
        {
        }
    }
}