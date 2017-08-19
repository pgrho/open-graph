namespace Shipwreck.OpenGraph
{
    public partial class MusicAlbum : GraphObject
    {
        public MusicAlbum()
            : this("music")
        {
        }

        internal MusicAlbum(string path)
            : base(path)
        {
        }
    }
}