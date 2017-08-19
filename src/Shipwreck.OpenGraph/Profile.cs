namespace Shipwreck.OpenGraph
{
    public sealed partial class Profile : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Profile" /> class.
        /// </summary>
        public Profile()
            : this("profile")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal Profile(string path)
            : base(path)
        {
        }
    }
}