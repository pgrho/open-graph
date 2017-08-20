namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a collection that filters elements in the root <see cref="Graph"/>'s <see cref="GraphObject.Children"/> which has specified property path and is instance of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    public sealed class GraphChildCollection<T> : GraphObjectChildCollection<T>
        where T : GraphObject
    {
        internal GraphChildCollection(Graph @object, PropertyName property)
            : base(@object, property)
        {
        }

        /// <inheritdoc />
        internal override bool ShouldInclude(GraphObject internalItem)
            => internalItem is T && internalItem.Path == Property;
    }
}