using System;
using System.Diagnostics;

namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Defines a property path with namespace URI.
    /// </summary>
    public struct PropertyPath : IEquatable<PropertyPath>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PropertyPath"/> struct with namespace URI.
        /// </summary>
        /// <param name="xmlns">The  namespace URI of this property.</param>
        public PropertyPath(string xmlns)
        {
            Namespace = xmlns;
            Path = null;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PropertyPath"/> struct with namespace URI and property path.
        /// </summary>
        /// <param name="xmlns">The  namespace URI of this property.</param>
        /// <param name="path">The property path without prefix.</param>
        public PropertyPath(string xmlns, string path)
        {
            Namespace = xmlns;
            Path = path;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets a namespace URI of this property.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets a property path without prefix.
        /// </summary>
        public string Path { get; set; }

        #endregion Properties

        #region Static Methods

        /// <summary>
        /// Returns a value that indicates whether two <see cref="PropertyPath" /> values are equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(PropertyPath left, PropertyPath right)
            => left.Namespace == right.Namespace && left.Path == right.Path;

        /// <summary>
        /// Returns a value that indicates whether two <see cref="PropertyPath" /> values have difference equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(PropertyPath left, PropertyPath right)
            => left.Namespace != right.Namespace || left.Path != right.Path;

        /// <summary>
        /// Returns a value that indicates whether two <see cref="PropertyPath" /> values are equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, <c>false</c>.</returns>
        public static bool Equals(PropertyPath left, PropertyPath right)
            => left == right;

        /// <summary>
        /// Addes path string to the specified property name.
        /// </summary>
        /// <param name="property">The base property path.</param>
        /// <param name="path">The path to append.</param>
        /// <returns>Combined path of <paramref name="property"/> and <paramref name="path"/>.</returns>
        public static PropertyPath operator +(PropertyPath property, string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return property;
            }
            if (string.IsNullOrEmpty(property.Path))
            {
                return new PropertyPath(property.Namespace, path);
            }

            if (path[0] == ':')
            {
#if DEBUG
                Debug.Fail("Invalid path to append.");
#endif
                return new PropertyPath(property.Namespace, property.Path + path);
            }

            return new PropertyPath(property.Namespace, property.Path + ":" + path);
        }

        /// <summary>
        /// Addes path string to the specified property name.
        /// </summary>
        /// <param name="property">The base property path.</param>
        /// <param name="path">The path to append.</param>
        /// <returns>Combined path of <paramref name="property"/> and <paramref name="path"/>.</returns>
        public static PropertyPath Add(PropertyPath property, string path)
            => property + path;

        #endregion Static Methods

        #region Instance Methods

        /// <inheritdoc />
        public override bool Equals(object obj)
            => obj is PropertyPath && this == (PropertyPath)obj;

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns><c>true</c> if the current object is equal to the <paramref name="other"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(PropertyPath other)
            => this == other;

        /// <summary>
        /// Determines whether this path instance match the specified combined path.
        /// </summary>
        /// <param name="property">The base path to compare.</param>
        /// <param name="path">The child path to compare.</param>
        /// <returns><c>true</c> if <paramref name="property"/> and <paramref name="property"/> match this property; otherwise, <c>false</c>.</returns>
        public bool Equals(PropertyPath property, string path)
            => StartsWith(property, path, out var b) && b;

        /// <inheritdoc />
        public override int GetHashCode()
            => (Namespace?.GetHashCode() ?? 0) ^ (Path?.GetHashCode() ?? 0);

        /// <inheritdoc />
        public override string ToString()
            => Namespace == null ? Path : $"{{{Namespace}}}{Path}";

        /// <summary>
        /// Determines whether the namespace URI and the beginning of this path instance match the specified <see cref="PropertyPath"/>.
        /// </summary>
        /// <param name="value">The path to compare.</param>
        /// <returns><c>true</c> if <paramref name="value"/> matches the beginning of this property; otherwise, <c>false</c>.</returns>
        public bool StartsWith(PropertyPath value)
            => StartsWith(value, out _);

        internal bool StartsWith(PropertyPath value, out bool matched)
        {
            if (Namespace == value.Namespace)
            {
                if (value.Path == null)
                {
                    matched = Path == null;
                    return true;
                }
                if (Path?.StartsWith(value.Path) == true)
                {
                    matched = Path.Length == value.Path.Length;
                    return matched || (Path.Length > value.Path.Length && Path[value.Path.Length] == ':');
                }
            }
            return matched = false;
        }

        /// <summary>
        /// Determines whether the namespace URI and the beginning of this path instance match the specified combined path.
        /// </summary>
        /// <param name="property">The base path to compare.</param>
        /// <param name="path">The child path to compare.</param>
        /// <returns><c>true</c> if <paramref name="property"/> and <paramref name="property"/> match the beginning of this property; otherwise, <c>false</c>.</returns>
        public bool StartsWith(PropertyPath property, string path)
            => StartsWith(property, path, out _);

        internal bool StartsWith(PropertyPath property, string path, out bool matched, bool skipCompareProperty = false)
        {
            var pl = Path?.Length ?? 0;
            var i = (property.Path?.Length + 1) ?? 0;
            var tl = i + path.Length;

            if (skipCompareProperty ? pl >= tl : StartsWith(property))
            {
                for (var j = 0; j < path.Length; j++)
                {
                    if (path[j] != Path[i + j])
                    {
                        return matched = false;
                    }
                }

                if (pl == tl)
                {
                    return matched = true;
                }
                else
                {
                    matched = false;
                    return Path[tl] == ':';
                }
            }
            return matched = false;
        }
    }

    #endregion Instance Methods
}