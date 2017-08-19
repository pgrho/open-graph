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
        public string ISBN
        {
            get => GetLocalProperty("isbn");
            set => SetLocalProperty("isbn", value);
        }

        [DefaultValue(null)]
        public DateTime? ReleaseDate
        {
            get => GetLocalPropertyAsDateTime("release_date");
            set => SetLocalProperty("release_date", value);
        }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(Path))
            {
                child = null;
                return false;
            }

            if (property.StartsWithChildPath(Path, "author", out var matched))
            {
                child = new Profile(Path + ":author");
                Children.Add(child);
                child.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}