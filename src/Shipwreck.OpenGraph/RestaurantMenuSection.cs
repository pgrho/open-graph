namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a section in a restaurant's menu. A section contains multiple menu items.
    /// </summary>
    public sealed partial class RestaurantMenuSection : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantMenuSection" /> class.
        /// </summary>
        public RestaurantMenuSection()
            : this(new PropertyPath(NamespaceCollection.Restaurant))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantMenuSection" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal RestaurantMenuSection(PropertyPath path)
            : base(path)
        {
        }
    }
}