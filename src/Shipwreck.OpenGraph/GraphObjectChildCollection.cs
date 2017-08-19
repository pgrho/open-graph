using System.Collections.Generic;

namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a collection that filters elements in <see cref="GraphObject.Children"/> which has specified property path and is instance of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    public class GraphObjectChildCollection<T> : PartialCollection<T, GraphObject>
        where T : GraphObject
    {
        internal GraphObjectChildCollection(GraphObject @object, string property)
        {
            Object = @object;
            Property = property;
        }

        internal GraphObject Object { get; }
        internal string Property { get; }

        /// <inheritdoc />
        internal override IList<GraphObject> PeekInternalList()
            => Object._Children;

        /// <inheritdoc />
        internal override IList<GraphObject> GetOrCreateInternalList()
            => Object.Children;

        /// <inheritdoc />
        internal override bool ShouldInclude(GraphObject internalItem)
            => internalItem is T && internalItem.Path.MachesChildPath(Object.Path, Property);

        /// <inheritdoc />
        internal override T ToItem(GraphObject internalItem)
            => (T)internalItem;

        /// <inheritdoc />
        internal override GraphObject ToInternalItem(T item)
            => item;

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            var other = obj as GraphObjectChildCollection<T>;
            return Object == other?.Object && Property == other.Property && GetType() == other.GetType();
        }

        /// <inheritdoc />
        public override int GetHashCode()
            => Object.GetHashCode() ^ Property.GetHashCode();
    }
}