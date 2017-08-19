namespace Shipwreck.OpenGraph
{
    public partial class MusicRadioStation : GraphObject
    {
        public MusicRadioStation()
            : this("music")
        {
        }

        internal MusicRadioStation(string path)
            : base(path)
        {
        }
    }
}