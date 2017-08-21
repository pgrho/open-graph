namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a person.
    /// </summary>
    public sealed partial class Profile : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Profile" /> class.
        /// </summary>
        public Profile()
            : this(new PropertyPath(NamespaceCollection.Profile))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal Profile(PropertyPath path)
            : base(path)
        {
        }
    }
}