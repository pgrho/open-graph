using System;
using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed partial class Book : GraphObject
    {
        public Book()
            : this("book")
        {
        }

        internal Book(string path)
            : base(path)
        {
        }

        [DefaultValue(null)]
        public string ISBN { get; set; }

        [DefaultValue(typeof(DateTime), "0001-01-01T00:00:00")]
        public DateTime ReleaseDate { get; set; }

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

            if (property.MachesChildPath(Path, "isbn"))
            {
                if (ISBN == null)
                {
                    ISBN = content;
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