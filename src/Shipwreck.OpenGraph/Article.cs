using System;
using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed partial class Article : GraphObject
    {
        public Article()
            : this("article")
        {
        }

        internal Article(string path)
            : base(path)
        {
        }

        [DefaultValue(typeof(DateTime), "0001-01-01T00:00:00")]
        public DateTime PublishedTime { get; set; }

        [DefaultValue(typeof(DateTime), "0001-01-01T00:00:00")]
        public DateTime ModifiedTime { get; set; }

        [DefaultValue(typeof(DateTime), "0001-01-01T00:00:00")]
        public DateTime ExpirationTime { get; set; }

        [DefaultValue(null)]
        public string Section { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(Path))
            {
                child = null;
                return false;
            }
            if (property.StartsWithChildPath(Path, "author", out var matched))
            {
                var a = new Profile(Path + ":author");
                Authors.Add(a);
                child = a.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }

            child = null;

            if (property.MachesChildPath(Path, "published_time"))
            {
                if (PublishedTime == DateTime.MinValue && DateTime.TryParse(content, out DateTime i))
                {
                    PublishedTime = i;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "modified_time"))
            {
                if (ModifiedTime == DateTime.MinValue && DateTime.TryParse(content, out DateTime i))
                {
                    ModifiedTime = i;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "expiration_time"))
            {
                if (ExpirationTime == DateTime.MinValue && DateTime.TryParse(content, out DateTime i))
                {
                    ExpirationTime = i;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "section"))
            {
                if (Section == null)
                {
                    Section = content;
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