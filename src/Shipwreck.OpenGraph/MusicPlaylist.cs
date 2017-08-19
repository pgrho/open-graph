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

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            child = null;
            if (!property.MachesPath(Path))
            {
                return false;
            }

            bool matched;
            if (property.StartsWithChildPath(Path, "song", out matched))
            {
                child = new MusicAlbumSong(Path + ":song");
            }
            else if (property.StartsWithChildPath(Path, "creator", out matched))
            {
                child = new Profile(Path + ":creator");
            }
            if (child != null)
            {
                Children.Add(child);
                child.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }
            return base.TryAddMetadata(property, content, out child);
        }
    }
}