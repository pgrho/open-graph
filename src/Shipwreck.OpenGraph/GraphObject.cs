using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Shipwreck.OpenGraph
{
    public abstract partial class GraphObject
    {
        internal List<GraphObject> _Children;
        internal List<GraphProperty> _LocalProperties;

        internal GraphObject(string path)
        {
            Path = path;
        }

        internal string Path { get; }

        internal virtual bool IsRoot => false;

        [DefaultValue(null)]
        public string Title
        {
            get => GetLocalProperty("title");
            set => SetLocalProperty("title", value);
        }

        [DefaultValue(null)]
        public string Url
        {
            get => GetLocalProperty("url");
            set => SetLocalProperty("url", value);
        }

        [DefaultValue(null)]
        public string Description
        {
            get => GetLocalProperty("description");
            set => SetLocalProperty("description", value);
        }

        [DefaultValue(null)]
        public string Determiner
        {
            get => GetLocalProperty("determiner");
            set => SetLocalProperty("determiner", value);
        }

        [DefaultValue(null)]
        public string Locale
        {
            get => GetLocalProperty("locale");
            set => SetLocalProperty("locale", value);
        }

        [DefaultValue(null)]
        public string SiteName
        {
            get => GetLocalProperty("site_name");
            set => SetLocalProperty("site_name", value);
        }

        #region Children

        public IList<GraphObject> Children
            => _Children ?? (_Children = new List<GraphObject>());

        public bool ShouldSerializeChildren()
            => _Children?.Count > 0;

        public void ResetChildren()
            => _Children?.Clear();

        #endregion Children

        #region LocalProperties

        public IList<GraphProperty> LocalProperties
            => _LocalProperties ?? (_LocalProperties = new List<GraphProperty>());

        public bool ShouldSerializeLocalProperties()
            => _LocalProperties?.Count > 0;

        public void ResetLocalProperties()
            => _LocalProperties?.Clear();

        #endregion LocalProperties

        internal void LoadProperties(IEnumerable<GraphProperty> properties)
        {
            var stack = new List<GraphObject>(2);
            stack.Add(this);

            foreach (var kv in properties)
            {
                for (int i = stack.Count - 1; i >= 0; i--)
                {
                    var obj = stack[i];

                    if (obj.TryAddMetadata(kv.Property, kv.Content, out GraphObject c))
                    {
                        stack.RemoveRange(i + 1, stack.Count - i - 1);

                        if (c != null)
                        {
                            stack.Add(c);
                        }
                        break;
                    }
                }
            }
        }

        internal virtual bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(Path))
            {
                child = null;

                if (IsRoot)
                {
                    LocalProperties.Add(new GraphProperty(property, content));
                    return true;
                }

                return false;
            }

            bool matched;
            child = null;
            if (property.StartsWithChildPath(Path, "image", out matched))
            {
                child = new GraphImage(Path + ":image");
            }
            else if (property.StartsWithChildPath(Path, "audio", out matched))
            {
                child = new GraphAudio(Path + ":audio");
            }
            else if (property.StartsWithChildPath(Path, "video", out matched))
            {
                child = new GraphVideo(Path + ":video");
            }

            if (child != null)
            {
                Children.Add(child);
                child.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }

            if (property.MachesChildPath(Path, "url"))
            {
                if (Url == null)
                {
                    Url = content;
                    return true;
                }
                return false;
            }
            else if (property.MachesChildPath(Path, "locale:alternate"))
            {
                AlternateLocales.Add(content);

                return true;
            }

            LocalProperties.Add(new GraphProperty(property, content));

            return true;
        }

        public string GetLocalProperty(string property)
            => _LocalProperties?.FirstOrDefault(kv => kv.Property.MachesChildPath(Path, property)).Content;

        public void SetLocalProperty(string property, string content)
        {
            if (_LocalProperties != null)
            {
                for (int i = _LocalProperties.Count - 1; i >= 0; i--)
                {
                    if (_LocalProperties[i].Property.MachesChildPath(Path, property))
                    {
                        _LocalProperties.RemoveAt(i);
                    }
                }
            }
            if (content != null)
            {
                LocalProperties.Add(new GraphProperty(Path + ":" + property, content));
            }
        }

        public int? GetLocalPropertyAsInt32(string property)
            => int.TryParse(GetLocalProperty(property), out int i) ? i : (int?)null;

        public void SetLocalProperty(string property, int? value)
            => SetLocalProperty(property, value?.ToString("R"));

        public DateTime? GetLocalPropertyAsDateTime(string property)
            => DateTime.TryParse(GetLocalProperty(property), out DateTime i) ? i : (DateTime?)null;

        public void SetLocalProperty(string property, DateTime? value)
            => SetLocalProperty(property, value?.ToString("o"));
    }
}