namespace Shipwreck.OpenGraph
{
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
        internal VideoTVShow(string path)
            : base(path)
        {
        }
    }
}