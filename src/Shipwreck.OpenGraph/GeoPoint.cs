namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents location data that can attached to other <see cref="GraphObject"/>.
    /// </summary>
    public sealed partial class GeoPoint : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoPoint" /> class.
        /// </summary>
        public GeoPoint()
            : this(new PropertyPath(NamespaceCollection.Place, "location"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoPoint" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal GeoPoint(PropertyPath path)
            : base(path)
        {
        }
    }
}