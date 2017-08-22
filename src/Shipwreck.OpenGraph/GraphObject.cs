using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Shipwreck.OpenGraph.Internal;

namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Provides a base type of Open Graph object.
    /// </summary>
    public abstract partial class GraphObject : IEnumerable<PropertyEntry>
    {
        internal GraphObjectCollection _Children;
        internal List<PropertyEntry> _LocalProperties;

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphObject" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal GraphObject(PropertyPath path)
        {
            if (path.IsRelative)
            {
                throw new ArgumentException($"{nameof(GraphObject)}.{nameof(Path)} must be absolute.");
            }
            _Path = path;
        }

        #region Properties

        /// <summary>
        /// Gets a parent object of this instance.
        /// </summary>
        public GraphObject Parent { get; internal set; }

        /// <summary>
        /// Gets a root graph that this instance belongs to.
        /// </summary>
        public Graph Graph
        {
            get
            {
                var n = this;
                while (n != null)
                {
                    var g = n as Graph;
                    if (g != null)
                    {
                        return g;
                    }
                    n = n.Parent;
                }
                return null;
            }
        }

        private PropertyPath _Path;

        /// <summary>
        /// Gets a property path or namespace URI for this instance.
        /// </summary>
        public PropertyPath Path
        {
            get => _Path;
            set
            {
                if (value != _Path)
                {
                    if (value.IsRelative)
                    {
                        throw new ArgumentException($"{nameof(GraphObject)}.{nameof(Path)} must be absolute.");
                    }

                    if (_LocalProperties != null)
                    {
                        for (int i = 0; i < _LocalProperties.Count; i++)
                        {
                            var kv = _LocalProperties[i];
                            var p = kv.Property;

                            if (!p.IsRelative && p.StartsWith(_Path))
                            {
                                _LocalProperties[i] = new PropertyEntry
                                    (
                                        value + (_Path.Path == null ? p.Path : p.Path.Substring(_Path.Path.Length + 1)),
                                        kv.Content);
                            }
                        }
                    }
                    if (_Children != null)
                    {
                        for (int i = 0; i < _Children.Count; i++)
                        {
                            var c = _Children[i];
                            var p = c.Path;

                            if (p.StartsWith(_Path))
                            {
                                c.Path = value + (_Path.Path == null ? p.Path : p.Path.Substring(_Path.Path.Length + 1));
                            }
                        }
                    }
                    _Path = value;
                }
            }
        }

        #region Children

        /// <summary>
        /// Gets or sets a list of all children of this object.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IList<GraphObject> Children
        {
            get => _Children ?? (_Children = new GraphObjectCollection(this));
            set
            {
                if (value != _Children)
                {
                    _Children?.Clear();
                    if (value?.Count > 0)
                    {
                        if (_Children == null)
                        {
                            _Children = new GraphObjectCollection(this);
                        }
                        foreach (var v in value)
                        {
                            _Children.Add(v);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Returns whether serialization processes should serialize the contents of the <see cref="Children"/> property on instances of this class.
        /// </summary>
        /// <returns><c>true</c> if the <see cref="Children"/> property value should be serialized; otherwise, <c>false</c>.</returns>
        public bool ShouldSerializeChildren()
            => _Children?.Count > 0;

        /// <summary>
        /// Resets the value for this <see cref="Children"/> to the default state.
        /// </summary>
        public void ResetChildren()
            => _Children?.Clear();

        #endregion Children

        #region LocalProperties

        /// <summary>
        /// Gets or sets a list of all local properties of this object.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IList<PropertyEntry> LocalProperties
        {
            get => CollectionHelper.GetCollection(ref _LocalProperties);
            set => CollectionHelper.SetCollection(ref _LocalProperties, value);
        }

        /// <summary>
        /// Returns whether serialization processes should serialize the contents of the <see cref="LocalProperties"/> property on instances of this class.
        /// </summary>
        /// <returns><c>true</c> if the <see cref="LocalProperties"/> property value should be serialized; otherwise, <c>false</c>.</returns>
        public bool ShouldSerializeLocalProperties()
            => _LocalProperties?.Count > 0;

        /// <summary>
        /// Resets the value for this <see cref="LocalProperties"/> to the default state.
        /// </summary>
        public void ResetLocalProperties()
            => _LocalProperties?.Clear();

        #endregion LocalProperties

        /// <summary>
        /// Gets or sets a first value of the specified property.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public string this[string property]
        {
            get => GetLocalProperty(property);
            set => SetLocalProperty(property, value);
        }

        #endregion Properties

        internal void LoadProperties<T>(T properties)
            where T : IPropertyEntryEnumerator
        {
            var stack = new List<GraphObject>(3);
            stack.Add(this);

            NamespaceCollection ns = null;

            using (properties)
            {
                while (properties.MoveNext())
                {
                    if (ns == null)
                    {
                        var g = Graph;
                        if (g != null)
                        {
                            if (g.ShouldSerializeNamespaces())
                            {
                                ns = g.Namespaces;
                            }
                            else
                            {
                                ns = g.Namespaces = properties.Namespaces;
                            }
                        }
                        else
                        {
                            ns = NamespaceCollection.Default;
                        }
                    }

                    var kv = properties.Current;

                    // TODO: lookup namespace if needed
                    if (kv.Property.Namespace == null)
                    {
                        var i = kv.Property.Path?.IndexOf(':') ?? 0;
                        if (i <= 0)
                        {
                            continue;
                        }

                        var uri = ns[kv.Property.Path.Substring(0, i).Trim()];
                        if (uri == null)
                        {
                            continue;
                        }

                        kv.Property = new PropertyPath(uri.Trim(), kv.Property.Path.Substring(i + 1));
                    }

                    if (string.IsNullOrEmpty(kv.Property.Path))
                    {
                        continue;
                    }

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
        }

        internal virtual bool TryAddMetadata(PropertyPath property, string content)
        {
            var pathMatched = property.StartsWith(Path, out var b) && !b;

            if (pathMatched || Parent == null)
            {
                var child = CreateNewChild(property, out var matched);

                if (child != null)
                {
                    Children.Add(child);
                    child.AddMetadataOrSetUrl(matched, property, content);
                    return true;
                }

                if (pathMatched && property.Equals(Path, "url"))
                {
                    if (Url == null)
                    {
                        Url = content;
                        return true;
                    }
                    return false;
                }

                LocalProperties.Add(new PropertyEntry(property, content));
                return true;
            }
            return false;
        }

        #region Local Property accessors

        /// <summary>
        /// Returns a first value of the local property path.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public string GetLocalProperty(string property)
            => _LocalProperties
                ?.FirstOrDefault
                    (
                        kv => kv.Property.IsRelative ? kv.Property.Path == property
                            : kv.Property.Equals(Path, property)
                    ).Content;

        /// <summary>
        /// Removes current <see cref="LocalProperties"/> items that local name is <paramref name="property"/> and adds a item that value is <paramref name="content"/>.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <param name="content">A new value to set.</param>
        public void SetLocalProperty(string property, string content)
        {
            if (_LocalProperties != null)
            {
                for (int i = _LocalProperties.Count - 1; i >= 0; i--)
                {
                    var p = _LocalProperties[i].Property;
                    if (p.IsRelative ? p.Path == property : p.Equals(Path, property))
                    {
                        _LocalProperties.RemoveAt(i);
                    }
                }
            }
            if (content != null)
            {
                LocalProperties.Add(new PropertyEntry(new PropertyPath(null, property), content));
            }
        }
        
        internal void SetLocalProperty(string property, IEnumerable<string> values)
        {
            var pc = values as PropertyEntryPartialCollection;
            if (pc?.Object == this && pc.Property.Equals(Path, property))
            {
                return;
            }
            SetLocalProperty(property, (string)null);

            if (values != null)
            {
                foreach (var v in values)
                {
                    LocalProperties.Add(new PropertyEntry(Path + property, v));
                }
            }
        }

        #endregion Local Property accessors

        /// <summary>
        /// Returns an enumerator that iterates properties of descendants of this object.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public virtual IEnumerator<PropertyEntry> GetEnumerator()
        {
            if (_LocalProperties != null)
            {
                foreach (var kv in _LocalProperties)
                {
                    if (kv.Property.IsRelative)
                    {
                        yield return new PropertyEntry(Path + kv.Property.Path, kv.Content);
                    }
                    else
                    {
                        yield return kv;
                    }
                }
            }

            if (_Children != null)
            {
                foreach (var c in _Children)
                {
                    foreach (var kv in c)
                    {
                        yield return kv;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        /// <summary>
        /// Returns a sequence of local properties is absolute path.
        /// </summary>
        /// <returns>Sequence of local properties.</returns>
        public IEnumerable<PropertyEntry> GetLocalProperties()
        {
            if (_LocalProperties != null)
            {
                foreach (var kv in _LocalProperties)
                {
                    if (kv.Property.IsRelative)
                    {
                        yield return new PropertyEntry(Path + kv.Property.Path, kv.Content);
                    }
                    else
                    {
                        yield return kv;
                    }
                }
            }
        }
    }
}