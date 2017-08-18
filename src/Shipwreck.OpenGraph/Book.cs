using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Shipwreck.OpenGraph
{
    public sealed partial class Book : GraphObject
    {
        private readonly string _Path;

        public Book()
        {
            _Path = "book";
        }

        internal Book(string path)
        {
            _Path = path;
        }

        [DefaultValue(null)]
        public string ISBN { get; set; }

        [DefaultValue(typeof(DateTime), "0001-01-01T00:00:00")]
        public DateTime ReleaseDate { get; set; }

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


            if (property.MachesChildPath(_Path, "isbn"))
            {
                if (ISBN == null)
                {
                    ISBN = content;
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
