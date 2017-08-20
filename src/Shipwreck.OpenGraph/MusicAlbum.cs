namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a music album.
    /// </summary>
    public sealed partial class MusicAlbum : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicAlbum" /> class.
        /// </summary>
        public MusicAlbum()
            : this(new PropertyName(NamespaceCollection.Music))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicAlbum" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal MusicAlbum(PropertyName path)
            : base(path)
        {
        }
    }
}