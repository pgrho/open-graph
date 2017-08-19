namespace Shipwreck.OpenGraph
{
    public sealed partial class GraphAudio : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphAudio" /> class.
        /// </summary>
        public GraphAudio()
            : this("og")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphAudio" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal GraphAudio(string path)
            : base(path)
        {
        }
    }
}