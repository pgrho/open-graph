using System.Collections.Generic;

namespace Shipwreck.OpenGraph.Internal
{
    /// <summary>
    /// Represents a collection that filters elements in <see cref="GraphObject.LocalProperties"/> which has specified property path.
    /// </summary>
    internal sealed class PropertyEntryPartialCollection : PartialCollection<string, PropertyEntry>
    {
        internal PropertyEntryPartialCollection(GraphObject @object, PropertyPath property)
        {
            Object = @object;
            Property = property;
        }

        internal GraphObject Object { get; }
        internal PropertyPath Property { get; }

        /// <inheritdoc />
        internal override IList<PropertyEntry> PeekInternalList()
            => Object._LocalProperties;

        /// <inheritdoc />
        internal override IList<PropertyEntry> GetOrCreateInternalList()
            => Object.LocalProperties;

        /// <inheritdoc />
        internal override bool ShouldInclude(PropertyEntry internalItem)
            // 1. Same type: direct compare
            => Property.IsRelative == internalItem.Property.IsRelative ? Property == internalItem.Property
                // 2. this.Property is relative: compare by argument.
                : Property.IsRelative ? internalItem.Property.Equals(Object.Path, Property.Path)
                // 3. this.Property is absolute: compare by Property.
                : Property.Equals(Object.Path, internalItem.Property.Path);

        /// <inheritdoc />
        internal override string ToItem(PropertyEntry internalItem)
            => internalItem.Content;

        /// <inheritdoc />
        internal override PropertyEntry ToInternalItem(string item)
            => new PropertyEntry(Property, item);
    }
}