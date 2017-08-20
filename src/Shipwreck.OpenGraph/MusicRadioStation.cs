namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a 'radio' station of a stream of audio.
    /// </summary>
    public partial class MusicRadioStation : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicRadioStation" /> class.
        /// </summary>
        public MusicRadioStation()
            : this(new PropertyName(NamespaceCollection.Music))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicRadioStation" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal MusicRadioStation(PropertyName path)
            : base(path)
        {
        }
    }
}