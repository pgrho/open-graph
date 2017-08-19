using System;

namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Defines a property name/content pair that can be set or retrieved.
    /// </summary>
    public struct GraphProperty : IEquatable<GraphProperty>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="GraphProperty"/> struct with property name and content.
        /// </summary>
        /// <param name="property">The  name of this property.</param>
        /// <param name="content">The content for this property.</param>
        public GraphProperty(string property, string content)
        {
            Property = property;
            Content = content;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets a name of this property.
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Gets or sets a content for this property.
        /// </summary>
        public string Content { get; set; }

        #endregion Properties

        #region Static Methods

        /// <summary>
        /// Returns a value that indicates whether two <see cref="GraphProperty" /> values are equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(GraphProperty left, GraphProperty right)
            => left.Property == right.Property && left.Content == right.Content;

        /// <summary>
        /// Returns a value that indicates whether two <see cref="GraphProperty" /> values have difference equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(GraphProperty left, GraphProperty right)
            => left.Property != right.Property || left.Content != right.Content;

        /// <summary>
        /// Returns a value that indicates whether two <see cref="GraphProperty" /> values are equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, <c>false</c>.</returns>
        public static bool Equals(GraphProperty left, GraphProperty right)
            => left == right;

        #endregion Static Methods

        #region Instance Methods

        /// <inheritdoc />
        public override bool Equals(object obj)
            => obj is GraphProperty && this == (GraphProperty)obj;

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns><c>true</c> if the current object is equal to the <paramref name="other"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(GraphProperty other)
            => this == other;

        /// <inheritdoc />
        public override int GetHashCode()
            => (Property?.GetHashCode() ?? 0) ^ (Content?.GetHashCode() ?? 0);

        /// <inheritdoc />
        public override string ToString()
            => $"{Property}= \"{Content}\"";

        #endregion Instance Methods
    }
}