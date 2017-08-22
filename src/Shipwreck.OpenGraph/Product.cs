namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a product. This includes both virtual and physical products, but it typically represents items that are available in an online store.
    /// </summary>
    public sealed partial class Product : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        public Product()
            : this(new PropertyPath(NamespaceCollection.Product))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal Product(PropertyPath path)
            : base(path)
        {
        }
    }
}