namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents an episode of a TV show and contains references to the actors and other professionals involved in its production.
    /// </summary>
    public sealed partial class VideoEpisode : VideoObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoEpisode" /> class.
        /// </summary>
        public VideoEpisode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoEpisode" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal VideoEpisode(string path)
            : base(path)
        {
        }
    }
}