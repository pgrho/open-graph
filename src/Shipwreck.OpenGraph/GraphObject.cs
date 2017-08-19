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

                    if (obj.TryAddMetadata(kv.Property, kv.Content))
                    {
                        stack.RemoveRange(i + 1, stack.Count - i - 1);

                        var c = obj._Children?.LastOrDefault();

                        while (c != null)
                        {
                            stack.Add(c);

                            c = c._Children?.LastOrDefault();
                        }
                        break;
                    }
                    else if (i > 0)
                    {
                        stack.RemoveRange(i, stack.Count - i);
                    }
                }
            }
        }

        internal virtual bool TryAddMetadata(string property, string content)
        {
            if (!property.MachesPath(Path))
            {
                if (IsRoot)
                {
                    LocalProperties.Add(new GraphProperty(property, content));
                    return true;
                }

                return false;
            }

            bool matched;

            var child = CreateNewChild(property, out matched);

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

        internal virtual GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "image", out matched))
            {
                return new GraphImage(Path + ":image");
            }
            else if (property.StartsWithChildPath(Path, "audio", out matched))
            {
                return new GraphAudio(Path + ":audio");
            }
            else if (property.StartsWithChildPath(Path, "video", out matched))
            {
                return new GraphVideo(Path + ":video");
            }
            return null;
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