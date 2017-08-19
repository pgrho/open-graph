using System;
using System.Collections;
using System.Collections.Generic;

namespace Shipwreck.OpenGraph
{
    public abstract class PartialCollection<TItem, TInternal> : IList<TItem>, IReadOnlyCollection<TItem>
    {
        internal PartialCollection()
        {
            Comparer = EqualityComparer<TItem>.Default;
        }

        public IEqualityComparer<TItem> Comparer { get; }

        #region Template Methods

        internal abstract IList<TInternal> PeekInternalList();

        internal abstract IList<TInternal> GetOrCreateInternalList();

        internal abstract bool ShouldInclude(TInternal internalItem);

        internal abstract TItem ToItem(TInternal internalItem);

        internal abstract TInternal ToInternalItem(TItem item);

        #endregion Template Methods

        #region ICollection<T> Properties

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

        #region IList<T> Properties

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

        #region IEnumerable<T> Methods

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

        public void Add(TItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            GetOrCreateInternalList().Add(ToInternalItem(item));
        }

        public void Clear()
        {
            var prop = PeekInternalList();
            if (prop != null)
            {
                for (var i = prop.Count - 1; i >= 0; i--)
                {
                    if (ShouldInclude(prop[i]))
                    {
                        prop.RemoveAt(i);
                    }
                }
            }
        }

        public bool Contains(TItem item)
            => IndexOf(item) >= 0;

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
                        props.RemoveAt(i);
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion ICollection<T> Methods

        #region IList<T> Methods

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
                        props.Insert(i, ToInternalItem(item));
                        return;
                    }
                }
            }
            if (index == j)
            {
                GetOrCreateInternalList().Add(ToInternalItem(item));
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

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
                            props.RemoveAt(i);
                            return;
                        }
                        j++;
                    }
                }
            }
        }

        #endregion IList<T> Methods
    }
}