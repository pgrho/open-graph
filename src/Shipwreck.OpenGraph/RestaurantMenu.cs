namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a restaurant's menu. A restaurant can have multiple menus, and each menu has multiple sections.
    /// </summary>
    public sealed partial class RestaurantMenu : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantMenu" /> class.
        /// </summary>
        public RestaurantMenu()
            : this(new PropertyPath(NamespaceCollection.Restaurant))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestaurantMenu" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal RestaurantMenu(PropertyPath path)
            : base(path)
        {
        }
    }
}