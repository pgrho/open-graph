namespace Shipwreck.OpenGraph
{
    public partial class MusicPlaylist : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicPlaylist" /> class.
        /// </summary>
        public MusicPlaylist()
            : this("music")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicPlaylist" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal MusicPlaylist(string path)
            : base(path)
        {
        }
    }
}