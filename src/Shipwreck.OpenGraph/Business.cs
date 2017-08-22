namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a place of business that has a location, operating hours and contact information that can attached to other <see cref="GraphObject"/>.
    /// </summary>
    public sealed partial class Business : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Business" /> class.
        /// </summary>
        public Business()
            : this(new PropertyPath(NamespaceCollection.Business))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Business" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal Business(PropertyPath path)
            : base(path)
        {
        }
    }
}