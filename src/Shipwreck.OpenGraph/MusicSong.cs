using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public partial class MusicSong : GraphObject
    {
        public MusicSong()
            : this("music")
        {
        }

        internal MusicSong(string path)
            : base(path)
        {
        }

        [DefaultValue(null)]
        public int? Duration
        {
            get => GetLocalPropertyAsInt32("duration");
            set => SetLocalProperty("duration", value);
        }

        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "album", out matched))
            {
                return new MusicSongAlbum(Path + ":album");
            }
            else if (property.StartsWithChildPath(Path, "musician", out matched))
            {
                return new Profile(Path + ":musician");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
}