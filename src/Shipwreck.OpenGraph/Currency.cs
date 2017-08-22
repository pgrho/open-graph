namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a currency that can attached to other <see cref="GraphObject"/>.
    /// </summary>
    public sealed partial class Currency : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        public Currency()
            : this(new PropertyPath(NamespaceCollection.OpenGraph))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Currency" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal Currency(PropertyPath path)
            : base(path)
        {
        }
    }
}