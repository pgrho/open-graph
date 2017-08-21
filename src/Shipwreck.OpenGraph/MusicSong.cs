namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a single song.
    /// </summary>
    public sealed partial class MusicSong : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicSong" /> class.
        /// </summary>
        public MusicSong()
            : this(new PropertyPath(NamespaceCollection.Music))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicSong" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal MusicSong(PropertyPath path)
            : base(path)
        {
        }
    }
}