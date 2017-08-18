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

            if (property.StartsWithChildPath(Path, "album"))
            {
                var a = new MusicSongAlbum(Path + ":album");
                Albums.Add(a);
                a.TryAddMetadata(property, content, out child);
                child = child ?? a;
                return true;
            }
            else if (property.StartsWithChildPath(Path, "musician"))
            {
                var m = new Profile(Path + ":musician");
                Musicians.Add(m);
                m.TryAddMetadata(property, content, out child);
                child = child ?? m;
                return true;
            }

            child = null;
            if (property.MachesChildPath(Path, "duration"))
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