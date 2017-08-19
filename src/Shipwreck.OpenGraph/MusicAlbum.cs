using System;
using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public partial class MusicAlbum : GraphObject
    {
        public MusicAlbum()
            : this("music")
        {
        }

        internal MusicAlbum(string path)
            : base(path)
        {
        }

        [DefaultValue(null)]
        public DateTime? ReleaseDate
        {
            get => GetLocalPropertyAsDateTime("release_date");
            set => SetLocalProperty("release_date", value);
        }

        internal override bool TryAddMetadata(string property, string content)
        {
            if (!property.MachesPath(Path))
            {
                return false;
            }

            bool matched;
            GraphObject child = null;
            if (property.StartsWithChildPath(Path, "song", out matched))
            {
                child = new MusicAlbumSong(Path + ":song");
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

            return base.TryAddMetadata(property, content);
        }
    }
}