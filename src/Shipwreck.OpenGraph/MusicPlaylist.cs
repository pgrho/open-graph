using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public partial class MusicPlaylist : GraphObject
    {
        public MusicPlaylist()
            : this("music")
        {
        }

        internal MusicPlaylist(string path)
            : base(path)
        {
        }

        [DefaultValue(null)]
        public Profile Creator { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(Path))
            {
                child = null;
                return false;
            }

            bool matched;
            if (property.StartsWithChildPath(Path, "song", out matched))
            {
                var s = new MusicAlbumSong(Path + ":song");
                Songs.Add(s);
                child = s.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }
            else if (property.StartsWithChildPath(Path, "creator", out matched))
            {
                if (Creator == null)
                {
                    Creator = new Profile(Path + ":creator");
                }
                child = Creator.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}