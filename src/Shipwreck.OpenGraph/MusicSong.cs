using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public partial class MusicSong : GraphObject
    {
        internal readonly string _Path;

        public MusicSong()
        {
            _Path = "music";
        }

        internal MusicSong(string path)
        {
            _Path = path;
        }

        [DefaultValue(0)]
        public int Duration { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(_Path))
            {
                child = null;
                return false;
            }

            if (property.StartsWithChildPath(_Path, "album"))
            {
                var a = new MusicSongAlbum(_Path + ":album");
                Albums.Add(a);
                a.TryAddMetadata(property, content, out child);
                child = child ?? a;
                return true;
            }
            else if (property.StartsWithChildPath(_Path, "musician"))
            {
                var m = new Profile(_Path + ":musician");
                Musicians.Add(m);
                m.TryAddMetadata(property, content, out child);
                child = child ?? m;
                return true;
            }

            child = null;
            if (property.MachesChildPath(_Path, "duration"))
            {
                if (Duration == 0 && int.TryParse(content, out int i))
                {
                    Duration = i;
                }

                return true;
            }

            return false;
        }
    }
}