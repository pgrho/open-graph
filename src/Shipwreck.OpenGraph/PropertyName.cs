using System;

namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Defines a property name with namespace URI.
    /// </summary>
    public struct PropertyName : IEquatable<PropertyName>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="PropertyName"/> struct with namespace URI.
        /// </summary>
        /// <param name="xmlns">The  namespace URI of this property.</param>
        public PropertyName(string xmlns)
        {
            Namespace = xmlns;
            Path = null;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PropertyName"/> struct with namespace URI and property path.
        /// </summary>
        /// <param name="xmlns">The  namespace URI of this property.</param>
        /// <param name="path">The property path without prefix.</param>
        public PropertyName(string xmlns, string path)
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
        /// Returns a value that indicates whether two <see cref="PropertyName" /> values are equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(PropertyName left, PropertyName right)
            => left.Namespace == right.Namespace && left.Path == right.Path;

        /// <summary>
        /// Returns a value that indicates whether two <see cref="PropertyName" /> values have difference equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(PropertyName left, PropertyName right)
            => left.Namespace != right.Namespace || left.Path != right.Path;

        /// <summary>
        /// Returns a value that indicates whether two <see cref="PropertyName" /> values are equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, <c>false</c>.</returns>
        public static bool Equals(PropertyName left, PropertyName right)
            => left == right;

        #endregion Static Methods

        public static PropertyName operator +(PropertyName left, string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return left;
            }
            if (string.IsNullOrEmpty(left.Path))
            {
                return new PropertyName(left.Namespace, path);
            }

            return new PropertyName(left.Namespace, left.Path + ":" + path);
        }

        #region Instance Methods

        /// <inheritdoc />
        public override bool Equals(object obj)
            => obj is PropertyName && this == (PropertyName)obj;

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns><c>true</c> if the current object is equal to the <paramref name="other"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(PropertyName other)
            => this == other;

        /// <inheritdoc />
        public override int GetHashCode()
            => (Namespace?.GetHashCode() ?? 0) ^ (Path?.GetHashCode() ?? 0);

        /// <inheritdoc />
        public override string ToString()
            => Namespace == null ? Path : $"{{{Namespace}}}{Path}";

        public bool StartsWith(PropertyName other)
            => Namespace == other.Namespace
                && (other.Path == null
                    || (Path?.StartsWith(other.Path) == true
                        && (Path.Length == other.Path.Length
                        || (Path.Length > other.Path.Length && Path[other.Path.Length] == ':'))));

        public bool Equals(PropertyName parentPath, string childPath)
            => StartsWith(parentPath, childPath, out var b) && b;

        public bool StartsWith(PropertyName parentPath, string childPath)
            => StartsWith(parentPath, childPath, out _);

        internal bool StartsWith(PropertyName parentPath, out bool matched)
        {
            // TODO: avoid string allocation
            if (StartsWith(parentPath))
            {
                matched = this == parentPath;
                return true;
            }
            matched = false;
            return false;
        }

        internal bool StartsWith(PropertyName parentPath, string childPath, out bool matched, bool skipOther = false)
        {
            // TODO: avoid string allocation
            var op = parentPath + childPath;
            if (StartsWith(op))
            {
                matched = this == op;
                return true;
            }
            matched = false;
            return false;
        }
    }

    #endregion Instance Methods
}