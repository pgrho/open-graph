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

        [DefaultValue(0)]
        public int Duration { get; set; }

        [DefaultValue(typeof(DateTime), "0001-01-01T00:00:00")]
        public DateTime ReleaseDate { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(Path))
            {
                child = null;
                return false;
            }

            bool matched;
            if (property.StartsWithChildPath(Path, "actor", out matched))
            {
                var a = new Actor(Path + ":actor");
                Actors.Add(a);
                child = a.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }
            else if (property.StartsWithChildPath(Path, "director", out matched))
            {
                var d = new Profile(Path + ":director");
                Directors.Add(d);
                child = d.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }
            else if (property.StartsWithChildPath(Path, "writer", out matched))
            {
                var w = new Profile(Path + ":writer");
                Writers.Add(w);
                child = w.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }

            child = null;
            if (property.MachesChildPath(Path, "duration"))
            {
                if (Duration == 0 && int.TryParse(content, out int i))
                {
                    Duration = i;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "release_date"))
            {
                if (ReleaseDate == DateTime.MinValue && DateTime.TryParse(content, out DateTime i))
                {
                    ReleaseDate = i;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "tag"))
            {
                Tags.Add(content);

                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}