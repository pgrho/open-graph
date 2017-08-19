namespace Shipwreck.OpenGraph
{
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