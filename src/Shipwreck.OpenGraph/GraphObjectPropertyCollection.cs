using System.Collections.Generic;

namespace Shipwreck.OpenGraph
{
    public sealed class GraphObjectPropertyCollection : PartialCollection<string, GraphProperty>, IList<string>, IReadOnlyList<string>
    {
        private readonly GraphObject _Object;
        private readonly string _Property;

        internal GraphObjectPropertyCollection(GraphObject @object, string property)
        {
            _Object = @object;
            _Property = property;
        }

        internal override IList<GraphProperty> PeekInternalList()
            => _Object._LocalProperties;

        internal override IList<GraphProperty> GetOrCreateInternalList()
            => _Object.LocalProperties;

        internal override bool ShouldInclude(GraphProperty internalItem)
            => internalItem.Property.MachesChildPath(_Object.Path, _Property);

        internal override string ToItem(GraphProperty internalItem)
            => internalItem.Content;

        internal override GraphProperty ToInternalItem(string item)
            => new GraphProperty(_Object.Path + ":" + _Property, item);
    }
}