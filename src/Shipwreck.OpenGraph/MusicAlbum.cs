using System;
using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public partial class MusicAlbum : GraphObject
    {
        internal readonly string _Path;

        public MusicAlbum()
        {
            _Path = "music";
        }

        internal MusicAlbum(string path)
        {
            _Path = path;
        }

        [DefaultValue(typeof(DateTime), "0001-01-01T00:00:00")]
        public DateTime ReleaseDate { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(_Path))
            {
                child = null;
                return false;
            }

            if (property.StartsWithChildPath(_Path, "song"))
            {
                var s = new MusicAlbumSong(_Path + ":song");
                Songs.Add(s);
                s.TryAddMetadata(property, content, out child);
                child = child ?? s;
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
            if (property.MachesChildPath(_Path, "release_date"))
            {
                if (ReleaseDate == DateTime.MinValue && DateTime.TryParse(content, out DateTime i))
                {
                    ReleaseDate = i;
                }

                return true;
            }

            return false;
        }
    }
}