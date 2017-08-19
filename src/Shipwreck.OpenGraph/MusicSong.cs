namespace Shipwreck.OpenGraph
{
    public sealed partial class MusicSong : GraphObject
    {
        public MusicSong()
            : this("music")
        {
        }

        internal MusicSong(string path)
            : base(path)
        {
        }
    }
}