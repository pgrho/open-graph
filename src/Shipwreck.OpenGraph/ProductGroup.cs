namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a group of product items.
    /// </summary>
    public sealed partial class ProductGroup : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductGroup" /> class.
        /// </summary>
        public ProductGroup()
            : this(new PropertyPath(NamespaceCollection.Product))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductGroup" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal ProductGroup(PropertyPath path)
            : base(path)
        {
        }
    }
}