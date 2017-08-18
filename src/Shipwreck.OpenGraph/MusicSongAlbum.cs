using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed class MusicSongAlbum : MusicAlbum
    {
        public MusicSongAlbum()
        {
        }

        internal MusicSongAlbum(string path)
            : base(path)
        {
        }

        [DefaultValue(0)]
        public int Disc { get; set; }

        [DefaultValue(0)]
        public int Track { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(_Path))
            {
                child = null;
                return false;
            }

            if (property.MachesChildPath(_Path, "disc"))
            {
                if (Disc == 0 && int.TryParse(content, out int i))
                {
                    Disc = i;
                }

                child = null;
                return true;
            }
            else if (property.MachesChildPath(_Path, "track"))
            {
                if (Track == 0 && int.TryParse(content, out int i))
                {
                    Track = i;
                }

                child = null;
                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}