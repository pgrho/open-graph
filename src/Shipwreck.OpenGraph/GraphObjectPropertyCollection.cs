using System.Collections.Generic;

namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a collection that filters elements in <see cref="GraphObject.LocalProperties"/> which has specified property path.
    /// </summary>
    public sealed class GraphObjectPropertyCollection : PartialCollection<string, GraphProperty>
    {
        private readonly GraphObject _Object;
        private readonly string _Property;

        internal GraphObjectPropertyCollection(GraphObject @object, string property)
        {
            _Object = @object;
            _Property = property;
        }

        /// <inheritdoc />
        internal override IList<GraphProperty> PeekInternalList()
            => _Object._LocalProperties;

        /// <inheritdoc />
        internal override IList<GraphProperty> GetOrCreateInternalList()
            => _Object.LocalProperties;

        /// <inheritdoc />
        internal override bool ShouldInclude(GraphProperty internalItem)
            => internalItem.Property.MachesChildPath(_Object.Path, _Property);

        /// <inheritdoc />
        internal override string ToItem(GraphProperty internalItem)
            => internalItem.Content;

        /// <inheritdoc />
        internal override GraphProperty ToInternalItem(string item)
            => new GraphProperty(_Object.Path + ":" + _Property, item);
    }
}