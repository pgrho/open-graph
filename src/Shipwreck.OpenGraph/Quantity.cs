namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a quantity that can attached to other <see cref="GraphObject"/>.
    /// </summary>
    public sealed partial class Quantity : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity" /> class.
        /// </summary>
        public Quantity()
            : this(new PropertyPath(NamespaceCollection.OpenGraph))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal Quantity(PropertyPath path)
            : base(path)
        {
        }
    }
}