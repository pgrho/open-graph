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

        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "actor", out matched))
            {
                return new Actor(Path + ":actor");
            }
            else if (property.StartsWithChildPath(Path, "director", out matched))
            {
                return new Profile(Path + ":director");
            }
            else if (property.StartsWithChildPath(Path, "writer", out matched))
            {
                return new Profile(Path + ":writer");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
}