namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents an iOS application attached to the graph.
    /// </summary>
    public sealed partial class IosApplink : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosApplink" /> class.
        /// </summary>
        public IosApplink()
            : this(new PropertyName(NamespaceCollection.Applink, "ios"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IosApplink" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal IosApplink(PropertyName path)
            : base(path)
        {
        }
    }
}