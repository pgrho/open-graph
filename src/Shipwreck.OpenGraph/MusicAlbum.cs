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

        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "song", out matched))
            {
                return new MusicAlbumSong(Path + ":song");
            }
            else if (property.StartsWithChildPath(Path, "musician", out matched))
            {
                return new Profile(Path + ":musician");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
}