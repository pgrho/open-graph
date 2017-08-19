using System.ComponentModel;
using System.Linq;

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
        public Profile Creator
        {
            get => new GraphObjectChildCollection<Profile>(this, "creator").FirstOrDefault();
        }

        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "song", out matched))
            {
                return new MusicAlbumSong(Path + ":song");
            }
            else if (property.StartsWithChildPath(Path, "creator", out matched))
            {
                return new Profile(Path + ":creator");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
}