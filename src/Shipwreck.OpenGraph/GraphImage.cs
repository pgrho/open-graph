namespace Shipwreck.OpenGraph
{
    public sealed partial class GraphImage : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphImage" /> class.
        /// </summary>
        public GraphImage()
            : this("og")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphImage" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal GraphImage(string path)
            : base(path)
        {
        }
    }
}