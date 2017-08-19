namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents an audio resource that can attached to other <see cref="GraphObject"/>.
    /// </summary>
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