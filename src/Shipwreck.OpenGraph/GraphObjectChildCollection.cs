using System.Collections.Generic;

namespace Shipwreck.OpenGraph
{
    public sealed class GraphObjectChildCollection<T> : PartialCollection<T, GraphObject>
        where T : GraphObject
    {
        private readonly GraphObject _Object;
        private readonly string _Property;

        internal GraphObjectChildCollection(GraphObject @object, string property)
        {
            _Object = @object;
            _Property = property;
        }

        /// <inheritdoc />
        internal override IList<GraphObject> PeekInternalList()
            => _Object._Children;

        /// <inheritdoc />
        internal override IList<GraphObject> GetOrCreateInternalList()
            => _Object.Children;

        /// <inheritdoc />
        internal override bool ShouldInclude(GraphObject internalItem)
            => internalItem is T && internalItem.Path.MachesChildPath(_Object.Path, _Property);

        /// <inheritdoc />
        internal override T ToItem(GraphObject internalItem)
            => (T)internalItem;

        /// <inheritdoc />
        internal override GraphObject ToInternalItem(T item)
            => item;
    }
}