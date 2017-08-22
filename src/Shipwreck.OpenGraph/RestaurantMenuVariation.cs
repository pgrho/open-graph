namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a single variation on a restaurant's menu item.
    /// </summary>
    public sealed partial class RestaurantMenuVariation : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantMenuVariation" /> class.
        /// </summary>
        public RestaurantMenuVariation()
            : this(new PropertyPath(NamespaceCollection.Restaurant, "variation"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantMenuVariation" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal RestaurantMenuVariation(PropertyPath path)
            : base(path)
        {
        }
    }
}