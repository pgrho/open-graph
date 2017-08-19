namespace Shipwreck.OpenGraph
{
    public partial class MusicRadioStation : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicRadioStation" /> class.
        /// </summary>
        public MusicRadioStation()
            : this("music")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicRadioStation" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal MusicRadioStation(string path)
            : base(path)
        {
        }
    }
}