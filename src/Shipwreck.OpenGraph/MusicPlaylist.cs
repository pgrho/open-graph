namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a music playlist.
    /// </summary>
    public partial class MusicPlaylist : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicPlaylist" /> class.
        /// </summary>
        public MusicPlaylist()
            : this(new PropertyPath(NamespaceCollection.Music))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicPlaylist" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal MusicPlaylist(PropertyPath path)
            : base(path)
        {
        }
    }
}