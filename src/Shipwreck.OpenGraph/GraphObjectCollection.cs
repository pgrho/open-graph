using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Shipwreck.OpenGraph
{
    internal sealed class GraphObjectCollection : Collection<GraphObject>
    {
        private readonly GraphObject Object;

        internal GraphObjectCollection(GraphObject @object)
            : base(new List<GraphObject>(4))
        {
            Object = @object;
        }

        /// <inheritdoc />
        protected override void ClearItems()
        {
            foreach (var item in this)
            {
                item.Parent = null;
            }
            base.ClearItems();
        }

        /// <inheritdoc />
        protected override void InsertItem(int index, GraphObject item)
        {
            OnAddingItem(item);

            base.InsertItem(index, item);
        }

        /// <inheritdoc />
        protected override void RemoveItem(int index)
        {
            this[index].Parent = null;
            base.RemoveItem(index);
        }

        /// <inheritdoc />
        protected override void SetItem(int index, GraphObject item)
        {
            this[index].Parent = null;

            OnAddingItem(item);

            base.SetItem(index, item);
        }

        private void OnAddingItem(GraphObject item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (item.Parent != null)
            {
                throw new InvalidOperationException("Specified item is already attached to an object.");
            }
            item.Parent = Object;
        }
    }
}