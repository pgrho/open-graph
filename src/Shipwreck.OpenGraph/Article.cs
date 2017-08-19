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

        [DefaultValue(null)]
        public DateTime? PublishedTime
        {
            get => GetLocalPropertyAsDateTime("published_time");
            set => SetLocalProperty("published_time", value);
        }

        [DefaultValue(null)]
        public DateTime? ModifiedTime
        {
            get => GetLocalPropertyAsDateTime("modified_time");
            set => SetLocalProperty("modified_time", value);
        }

        [DefaultValue(null)]
        public DateTime? ExpirationTime
        {
            get => GetLocalPropertyAsDateTime("expiration_time");
            set => SetLocalProperty("expiration_time", value);
        }

        [DefaultValue(null)]
        public string Section
        {
            get => GetLocalProperty("section");
            set => SetLocalProperty("section", value);
        }

        internal override bool TryAddMetadata(string property, string content)
        {
            if (!property.MachesPath(Path))
            {
                return false;
            }
            if (property.StartsWithChildPath(Path, "author", out var matched))
            {
                var child = new Profile(Path + ":author");
                Children.Add(child);
                child.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }

            return base.TryAddMetadata(property, content);
        }
    }
}