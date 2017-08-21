using System;
using System.Collections;
using System.Collections.Generic;

namespace Shipwreck.OpenGraph.Internal
{
    /// <summary>
    /// Represents a collection that filters elements in another collection which matches condition.
    /// </summary>
    internal abstract class PartialCollection<TItem, TInternal> : IList<TItem>, IReadOnlyCollection<TItem>, IList
    {
        internal PartialCollection()
        {
            Comparer = EqualityComparer<TItem>.Default;
        }

        /// <summary>
        /// Gets the <see cref="IEqualityComparer{T}"/> that is used to determine equality of elements.
        /// </summary>
        protected IEqualityComparer<TItem> Comparer { get; }

        #region Template Methods

        internal abstract IList<TInternal> PeekInternalList();

        internal abstract IList<TInternal> GetOrCreateInternalList();

        internal abstract bool ShouldInclude(TInternal internalItem);

        internal abstract TItem ToItem(TInternal internalItem);

        internal abstract TInternal ToInternalItem(TItem item);

        #endregion Template Methods

        #region Extension Points

        internal virtual void InsertInternalItem(int index, TInternal internalItem)
            => GetOrCreateInternalList().Insert(index, internalItem);

        internal virtual void RemoveInternalItem(int index)
            => GetOrCreateInternalList().RemoveAt(index);

        #endregion Extension Points

        #region ICollection<T> Properties

        /// <summary>
        /// Gets the number of elements contained in this collection.
        /// </summary>
        public int Count
        {
            get
            {
                var props = PeekInternalList();

                var j = 0;
                if (props != null)
                {
                    for (int i = 0; i < props.Count; i++)
                    {
                        var kv = props[i];
                        if (ShouldInclude(kv))
                        {
                            j++;
                        }
                    }
                }
                return j;
            }
        }

        bool ICollection<TItem>.IsReadOnly
          => false;

        #endregion ICollection<T> Properties

        #region ICollection Properties

        bool ICollection.IsSynchronized => false;

        object ICollection.SyncRoot
            => this;

        #endregion ICollection Properties

        #region IList<T> Properties

        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <returns>The element at the specified index.</returns>
        public TItem this[int index]
        {
            get
            {
                var props = PeekInternalList();

                var j = 0;
                if (props != null)
                {
                    for (int i = 0; i < props.Count; i++)
                    {
                        var kv = props[i];
                        if (ShouldInclude(kv) && j++ == index)
                        {
                            return ToItem(kv);
                        }
                    }
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                var props = PeekInternalList();

                var j = 0;
                if (props != null)
                {
                    for (int i = 0; i < props.Count; i++)
                    {
                        var kv = props[i];
                        if (ShouldInclude(kv) && j++ == index)
                        {
                            props[i] = ToInternalItem(value);
                            return;
                        }
                    }
                }
                if (index == j)
                {
                    GetOrCreateInternalList().Add(ToInternalItem(value));
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        #endregion IList<T> Properties

        #region IList Properties

        object IList.this[int index]
        {
            get => this[index];
            set => this[index] = (TItem)value;
        }

        bool IList.IsFixedSize
            => false;

        bool IList.IsReadOnly
            => false;

        #endregion IList Properties

        #region IEnumerable<T> Methods

        /// <summary>
        /// Returns an enumerator that iterates through this collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public IEnumerator<TItem> GetEnumerator()
        {
            var props = PeekInternalList();

            if (props != null)
            {
                foreach (var kv in props)
                {
                    if (ShouldInclude(kv))
                    {
                        yield return ToItem(kv);
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        #endregion IEnumerable<T> Methods

        #region ICollection<T> Methods

        /// <summary>
        /// Adds an object to the end of the collection.
        /// </summary>
        /// <param name="item">The object to be added to the end of the collection.</param>
        public void Add(TItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            InsertInternalItem(PeekInternalList()?.Count ?? 0, ToInternalItem(item));
        }

        /// <summary>
        /// Removes all elements from the collection.
        /// </summary>
        public void Clear()
        {
            var prop = PeekInternalList();
            if (prop != null)
            {
                for (var i = prop.Count - 1; i >= 0; i--)
                {
                    if (ShouldInclude(prop[i]))
                    {
                        RemoveInternalItem(i);
                    }
                }
            }
        }

        /// <summary>
        /// Determines whether an element is in the collection.
        /// </summary>
        /// <param name="item">The object to locate in the collection.</param>
        /// <returns><c>true</c> if item is found in the collection; otherwise, <c>false</c>.</returns>
        public bool Contains(TItem item)
            => IndexOf(item) >= 0;

        /// <summary>
        /// Copies the entire collection to a compatible one-dimensional array, starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the elements copied from collection.</param>
        /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
        public void CopyTo(TItem[] array, int arrayIndex)
        {
            var props = PeekInternalList();

            if (props != null)
            {
                foreach (var kv in props)
                {
                    if (ShouldInclude(kv))
                    {
                        array[arrayIndex++] = ToItem(kv);
                    }
                }
            }
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the collection.
        /// </summary>
        /// <param name="item">The object to remove from collection.</param>
        /// <returns>
        /// <c>true</c> if item is successfully removed; otherwise, <c>false</c>.
        /// This method also returns false if item was not found in the collection.
        /// </returns>
        public bool Remove(TItem item)
        {
            var props = PeekInternalList();

            if (props != null)
            {
                for (int i = 0; i < props.Count; i++)
                {
                    var kv = props[i];
                    if (ShouldInclude(kv) && Comparer.Equals(ToItem(kv), item))
                    {
                        RemoveInternalItem(i);
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion ICollection<T> Methods

        #region ICollection Methods

        void ICollection.CopyTo(Array array, int index)
            => CopyTo((TItem[])array, index);

        #endregion ICollection Methods

        #region IList<T> Methods

        /// <summary>
        /// Searches for the specified object and returns the zero-based index of the first occurrence within the entire collection.
        /// </summary>
        /// <param name="item">The object to locate in the collection.</param>
        /// <returns>The zero-based index of the first occurrence of item within the entire collection, if found; otherwise, -1.</returns>
        public int IndexOf(TItem item)
        {
            var props = PeekInternalList();

            var i = 0;
            if (props != null)
            {
                foreach (var kv in props)
                {
                    if (ShouldInclude(kv))
                    {
                        if (Comparer.Equals(ToItem(kv), item))
                        {
                            return i;
                        }
                        i++;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// Inserts an element into the collection at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
        /// <param name="item">The object to insert.</param>
        public void Insert(int index, TItem item)
        {
            var props = PeekInternalList();

            var j = 0;
            if (props != null)
            {
                for (int i = 0; i < props.Count; i++)
                {
                    var kv = props[i];
                    if (ShouldInclude(kv) && j++ == index)
                    {
                        InsertInternalItem(i, ToInternalItem(item));
                        return;
                    }
                }
            }
            if (index == j)
            {
                InsertInternalItem(props.Count, ToInternalItem(item));
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// Removes the element at the specified index of the collection.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        public void RemoveAt(int index)
        {
            var props = PeekInternalList();

            var j = 0;
            if (props != null)
            {
                for (int i = 0; i < props.Count; i++)
                {
                    var kv = props[i];
                    if (ShouldInclude(kv))
                    {
                        if (j == index)
                        {
                            RemoveInternalItem(i);
                            return;
                        }
                        j++;
                    }
                }
            }
        }

        #endregion IList<T> Methods

        #region IList Methods

        int IList.Add(object value)
        {
            Add((TItem)value);
            return Count - 1;
        }

        bool IList.Contains(object value)
            => value is TItem && Contains((TItem)value);

        int IList.IndexOf(object value)
            => value is TItem ? IndexOf((TItem)value) : -1;

        void IList.Insert(int index, object value)
            => Insert(index, (TItem)value);

        void IList.Remove(object value)
        {
            if (value is TItem)
            {
                Remove((TItem)value);
            }
        }

        #endregion IList Methods
    }
}