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

            if (property.StartsWithChildPath(Path, "song"))
            {
                var s = new MusicAlbumSong(Path + ":song");
                Songs.Add(s);
                s.TryAddMetadata(property, content, out child);
                child = child ?? s;
                return true;
            }
            else if (property.StartsWithChildPath(Path, "creator"))
            {
                if (Creator == null)
                {
                    Creator = new Profile(Path + ":creator");
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