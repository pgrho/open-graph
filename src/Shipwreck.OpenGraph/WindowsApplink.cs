namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents an Windows application attached to the graph.
    /// </summary>
    public sealed partial class WindowsApplink : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsApplink" /> class.
        /// </summary>
        public WindowsApplink()
            : this("al")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsApplink" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal WindowsApplink(string path)
            : base(path)
        {
        }
    }
}