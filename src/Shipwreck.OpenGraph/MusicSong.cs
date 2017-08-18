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

        [DefaultValue(0)]
        public int Duration { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(Path))
            {
                child = null;
                return false;
            }

            bool matched;
            if (property.StartsWithChildPath(Path, "album", out matched))
            {
                var a = new MusicSongAlbum(Path + ":album");
                Albums.Add(a);
                child = a.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }
            else if (property.StartsWithChildPath(Path, "musician", out matched))
            {
                var m = new Profile(Path + ":musician");
                Musicians.Add(m);
                child = m.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }

            if (property.MachesChildPath(Path, "duration"))
            {
                if (Duration == 0 && int.TryParse(content, out int i))
                {
                    Duration = i;
                }

                child = null;
                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}