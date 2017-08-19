namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents an video resource that can attached to other <see cref="GraphObject"/>.
    /// </summary>
    public sealed partial class GraphVideo : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphVideo" /> class.
        /// </summary>
        public GraphVideo()
            : this("og")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphVideo" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal GraphVideo(string path)
            : base(path)
        {
        }
    }
}