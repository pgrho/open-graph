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

        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "author", out matched))
            {
                return new Profile(Path + ":author");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
}