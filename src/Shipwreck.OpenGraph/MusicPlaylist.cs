using System;
using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public partial class MusicPlaylist : GraphObject
    {
        internal readonly string _Path;

        public MusicPlaylist()
        {
            _Path = "music";
        }

        internal MusicPlaylist(string path)
        {
            _Path = path;
        }

        [DefaultValue(null)]
        public Profile Creator { get; set; }

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
            else if (property.StartsWithChildPath(_Path, "creator"))
            {
                if (Creator == null)
                {
                    Creator = new Profile(_Path + ":creator");
                }
                Creator.TryAddMetadata(property, content, out child);
                child = child ?? Creator;
                return true;
            }

            child = null;
            return false;
        }
    }
}