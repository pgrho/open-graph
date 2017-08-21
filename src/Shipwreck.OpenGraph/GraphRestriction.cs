namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a restriction of the attached resource.
    /// </summary>
    public sealed partial class GraphRestriction : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphRestriction" /> class.
        /// </summary>
        public GraphRestriction()
            : this(new PropertyPath(NamespaceCollection.OpenGraph, "restrictions"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphRestriction" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal GraphRestriction(PropertyPath path)
            : base(path)
        {
        }
    }
}