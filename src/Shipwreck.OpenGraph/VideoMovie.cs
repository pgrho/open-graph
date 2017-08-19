namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a movie, and contains references to the actors and other professionals involved in its production
    /// </summary>
    public sealed class VideoMovie : VideoObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMovie" /> class.
        /// </summary>
        public VideoMovie()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMovie" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal VideoMovie(string path)
            : base(path)
        {
        }
    }
}