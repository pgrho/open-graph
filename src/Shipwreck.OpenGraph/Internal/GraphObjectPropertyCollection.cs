using System.Collections.Generic;

namespace Shipwreck.OpenGraph.Internal
{
    /// <summary>
    /// Represents a collection that filters elements in <see cref="GraphObject.LocalProperties"/> which has specified property path.
    /// </summary>
    internal sealed class GraphObjectPropertyCollection : PartialCollection<string, PropertyEntry>
    {
        internal GraphObjectPropertyCollection(GraphObject @object, PropertyPath property)
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
            => internalItem.Property == Property;
        /// <inheritdoc />
        internal override string ToItem(PropertyEntry internalItem)
            => internalItem.Content;

        /// <inheritdoc />
        internal override PropertyEntry ToInternalItem(string item)
            => new PropertyEntry(Property, item);
    }
}