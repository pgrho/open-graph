using System;
using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public abstract partial class VideoObject : GraphObject
    {
        public VideoObject()
            : this("video")
        {
        }

        internal VideoObject(string path)
            : base(path)
        {
        }

        [DefaultValue(null)]
        public int? Duration
        {
            get => GetLocalPropertyAsInt32("duration");
            set => SetLocalProperty("duration", value);
        }

        [DefaultValue(null)]
        public DateTime? ReleaseDate
        {
            get => GetLocalPropertyAsDateTime("release_date");
            set => SetLocalProperty("release_date", value);
        }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            child = null;
            if (!property.MachesPath(Path))
            {
                return false;
            }

            bool matched;
            if (property.StartsWithChildPath(Path, "actor", out matched))
            {
                child = new Actor(Path + ":actor");
            }
            else if (property.StartsWithChildPath(Path, "director", out matched))
            {
                child = new Profile(Path + ":director");
            }
            else if (property.StartsWithChildPath(Path, "writer", out matched))
            {
                child = new Profile(Path + ":writer");
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