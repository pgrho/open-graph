namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a TV show, and contains references to the actors and other professionals involved in its production.
    /// </summary>
    public sealed class VideoTVShow : VideoObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTVShow" /> class.
        /// </summary>
        public VideoTVShow()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTVShow" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal VideoTVShow(PropertyName path)
            : base(path)
        {
        }
    }
}