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

        [DefaultValue(null)]
        public int? Duration
        {
            get => GetLocalPropertyAsInt32("duration");
            set => SetLocalProperty("duration", value);
        }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            child = null;
            if (!property.MachesPath(Path))
            {
                return false;
            }

            bool matched;
            if (property.StartsWithChildPath(Path, "album", out matched))
            {
                child = new MusicSongAlbum(Path + ":album");
            }
            else if (property.StartsWithChildPath(Path, "musician", out matched))
            {
                child = new Profile(Path + ":musician");
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