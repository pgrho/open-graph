using System.Collections.Generic;

namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a collection that filters elements in <see cref="GraphObject.LocalProperties"/> which has specified property path.
    /// </summary>
    public sealed class GraphObjectPropertyCollection : PartialCollection<string, GraphProperty>
    {
        internal GraphObjectPropertyCollection(GraphObject @object, string property)
        {
            Object = @object;
            Property = property;
        }

        internal GraphObject Object { get; }
        internal string Property { get; }

        /// <inheritdoc />
        internal override IList<GraphProperty> PeekInternalList()
            => Object._LocalProperties;

        /// <inheritdoc />
        internal override IList<GraphProperty> GetOrCreateInternalList()
            => Object.LocalProperties;

        /// <inheritdoc />
        internal override bool ShouldInclude(GraphProperty internalItem)
            => internalItem.Property.MachesChildPath(Object.Path, Property);

        /// <inheritdoc />
        internal override string ToItem(GraphProperty internalItem)
            => internalItem.Content;

        /// <inheritdoc />
        internal override GraphProperty ToInternalItem(string item)
            => new GraphProperty(Object.Path + ":" + Property, item);
    }
}