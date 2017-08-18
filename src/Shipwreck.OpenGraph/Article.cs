using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Shipwreck.OpenGraph
{
    public sealed partial class Article : GraphObject
    {
        private readonly string _Path;

        public Article()
        {
            _Path = "article";
        }

        internal Article(string path)
        {
            _Path = path;
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
            if (!property.MachesPath(_Path))
            {
                child = null;
                return false;
            }
            if (property.StartsWithChildPath(_Path, "author"))
            {
                var a = new Profile(_Path + ":author");
                Authors.Add(a);
                a.TryAddMetadata(property, content, out child);
                child = child ?? a;
                return true;
            }

            child = null;


            if (property.MachesChildPath(_Path, "published_time"))
            {
                if (PublishedTime == DateTime.MinValue && DateTime.TryParse(content, out DateTime i))
                {
                    PublishedTime = i;
                }

                return true;
            }
            else if (property.MachesChildPath(_Path, "modified_time"))
            {
                if (ModifiedTime == DateTime.MinValue && DateTime.TryParse(content, out DateTime i))
                {
                    ModifiedTime = i;
                }

                return true;
            }
            else if (property.MachesChildPath(_Path, "expiration_time"))
            {
                if (ExpirationTime == DateTime.MinValue && DateTime.TryParse(content, out DateTime i))
                {
                    ExpirationTime = i;
                }

                return true;
            }
            else if (property.MachesChildPath(_Path, "section"))
            {
                if (Section == null)
                {
                    Section = content;
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
