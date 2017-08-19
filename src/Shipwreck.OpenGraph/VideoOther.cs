namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a generic video, and contains references to the actors and other professionals involved in its production.
    /// </summary>
    public sealed class VideoOther : VideoObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoOther" /> class.
        /// </summary>
        public VideoOther()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoOther" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal VideoOther(string path)
            : base(path)
        {
        }
    }
}