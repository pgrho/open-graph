using System;
using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public abstract partial class VideoObject : GraphObject
    {
        internal readonly string _Path;

        public VideoObject()
        {
            _Path = "video";
        }

        internal VideoObject(string path)
        {
            _Path = path;
        }

        [DefaultValue(0)]
        public int Duration { get; set; }

        [DefaultValue(typeof(DateTime), "0001-01-01T00:00:00")]
        public DateTime ReleaseDate { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(_Path))
            {
                child = null;
                return false;
            }

            if (property.StartsWithChildPath(_Path, "actor"))
            {
                var a = new Actor(_Path + ":actor");
                Actors.Add(a);
                a.TryAddMetadata(property, content, out child);
                child = child ?? a;
                return true;
            }
            else if (property.StartsWithChildPath(_Path, "director"))
            {
                var d = new Profile(_Path + ":director");
                Directors.Add(d);
                d.TryAddMetadata(property, content, out child);
                child = child ?? d;
                return true;
            }
            else if (property.StartsWithChildPath(_Path, "writer"))
            {
                var w = new Profile(_Path + ":writer");
                Writers.Add(w);
                w.TryAddMetadata(property, content, out child);
                child = child ?? w;
                return true;
            }

            child = null;
            if (property.MachesChildPath(_Path, "duration"))
            {
                if (Duration == 0 && int.TryParse(content, out int i))
                {
                    Duration = i;
                }

                return true;
            }
            else if (property.MachesChildPath(_Path, "release_date"))
            {
                if (ReleaseDate == DateTime.MinValue && DateTime.TryParse(content, out DateTime i))
                {
                    ReleaseDate = i;
                }

                return true;
            }
            else if (property.MachesChildPath(_Path, "tag"))
            {
                Tags.Add(content);

                return true;
            }

            return false;
        }
    }
}