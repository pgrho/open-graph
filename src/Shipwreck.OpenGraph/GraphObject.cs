using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Provides a base type of Open Graph object.
    /// </summary>
    public abstract partial class GraphObject : IEnumerable<GraphProperty>
    {
        internal List<GraphObject> _Children;
        internal List<GraphProperty> _LocalProperties;

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphObject" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal GraphObject(string path)
        {
            Path = path;
        }

        #region Properties

        internal string Path { get; }

        internal virtual bool IsRoot => false;

        #region Children

        /// <summary>
        /// Gets or sets a list of all children of this object.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IList<GraphObject> Children
        {
            get => CollectionHelper.GetCollection(ref _Children);
            set => CollectionHelper.SetCollection(ref _Children, value);
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
        public IList<GraphProperty> LocalProperties
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

        #endregion Properties

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
            var pathMatched = property.MachesPath(Path);

            if (pathMatched || IsRoot)
            {
                var child = CreateNewChild(property, out var matched);

                if (child != null)
                {
                    Children.Add(child);
                    child.AddMetadataOrSetUrl(matched, property, content);
                    return true;
                }

                if (pathMatched && property.MachesChildPath(Path, "url"))
                {
                    if (Url == null)
                    {
                        Url = content;
                        return true;
                    }
                    return false;
                }

                LocalProperties.Add(new GraphProperty(property, content));
                return true;

            }
            return false;
        }

        #region Local Property accessors

        /// <summary>
        /// Returns a first value of the specified property.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public string GetLocalProperty(string property)
            => _LocalProperties?.FirstOrDefault(kv => kv.Property.MachesChildPath(Path, property)).Content;

        /// <summary>
        /// Removes current <see cref="LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="content"/>.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <param name="content">A new value to set.</param>
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

        /// <summary>
        /// Returns a first value of the specified property as boolean value.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public bool? GetLocalPropertyAsBoolean(string property)
            => bool.TryParse(GetLocalProperty(property), out bool i) ? i : (bool?)null;

        /// <summary>
        /// Removes current <see cref="LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(string property, bool? value)
            => SetLocalProperty(property, value == null ? null : value == true ? "true" : "false");

        /// <summary>
        /// Returns a first value of the specified property as integer value.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public int? GetLocalPropertyAsInt32(string property)
            => int.TryParse(GetLocalProperty(property), out int i) ? i : (int?)null;

        /// <summary>
        /// Removes current <see cref="LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(string property, int? value)
            => SetLocalProperty(property, value?.ToString("R"));

        /// <summary>
        /// Returns a first value of the specified property as float value.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public float? GetLocalPropertyAsSingle(string property)
            => float.TryParse(GetLocalProperty(property), out float i) ? i : (float?)null;

        /// <summary>
        /// Removes current <see cref="LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(string property, float? value)
            => SetLocalProperty(property, value?.ToString("R"));

        /// <summary>
        /// Returns a first value of the specified property as <see cref="DateTime"/> value.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public DateTime? GetLocalPropertyAsDateTime(string property)
            => DateTime.TryParse(GetLocalProperty(property), out DateTime i) ? i : (DateTime?)null;

        /// <summary>
        /// Removes current <see cref="LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(string property, DateTime? value)
            => SetLocalProperty(property, value?.ToString("o"));

        internal void SetLocalProperty(string property, IEnumerable<string> values)
        {
            var pc = values as GraphObjectPropertyCollection;
            if (pc?.Object == this && pc.Property == property)
            {
                return;
            }
            SetLocalProperty(property, (string)null);

            if (values != null)
            {
                foreach (var v in values)
                {
                    LocalProperties.Add(new GraphProperty(Path + ":" + property, v));
                }
            }
        }

        #endregion Local Property accessors

        /// <summary>
        /// Returns an enumerator that iterates properties of descendants of this object.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public virtual IEnumerator<GraphProperty> GetEnumerator()
        {
            if (_LocalProperties != null)
            {
                foreach (var kv in _LocalProperties)
                {
                    yield return kv;
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
    }
}