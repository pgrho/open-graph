namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a single item on a restaurant's menu. Every item belongs within a menu section.
    /// </summary>
    public sealed partial class RestaurantMenuItem : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantMenuItem" /> class.
        /// </summary>
        public RestaurantMenuItem()
            : this(new PropertyPath(NamespaceCollection.Restaurant))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantMenuItem" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal RestaurantMenuItem(PropertyPath path)
            : base(path)
        {
        }
    }
}