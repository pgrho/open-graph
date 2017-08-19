using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Shipwreck.OpenGraph
{
    public sealed class GraphObjectPropertyCollection : IList<string>, IReadOnlyList<string>
    {
        private readonly GraphObject _Object;
        private readonly string _Property;

        internal GraphObjectPropertyCollection(GraphObject @object, string property)
        {
            _Object = @object;
            _Property = property;
        }

        public string this[int index]
        {
            get => this.ElementAt(index);
            set
            {
                var props = _Object._LocalProperties;

                var j = 0;
                if (props != null)
                {
                    for (int i = 0; i < props.Count; i++)
                    {
                        var kv = props[i];
                        if (kv.Property.MachesChildPath(_Object.Path, _Property) && j++ == index)
                        {
                            props[i] = new GraphProperty(_Object.Path + ":" + _Property, value);
                            return;
                        }
                    }
                }
                if (index == j)
                {
                    _Object.LocalProperties.Add(new GraphProperty(_Object.Path + ":" + _Property, value));
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public int Count
            => _Object._LocalProperties == null ? 0 : this.Count();

        bool ICollection<string>.IsReadOnly
          => false;

        public void Add(string item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _Object.LocalProperties.Add(new GraphProperty(_Object.Path + ":" + _Property, item));
        }

        public void Clear()
            => _Object.SetLocalProperty(_Property, (string)null);

        public bool Contains(string item)
            => IndexOf(item) >= 0;

        public void CopyTo(string[] array, int arrayIndex)
        {
            var props = _Object._LocalProperties;

            if (props != null)
            {
                foreach (var kv in props)
                {
                    if (kv.Property.MachesChildPath(_Object.Path, _Property))
                    {
                        array[arrayIndex++] = kv.Content;
                    }
                }
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            var props = _Object._LocalProperties;

            if (props != null)
            {
                foreach (var kv in props)
                {
                    if (kv.Property.MachesChildPath(_Object.Path, _Property))
                    {
                        yield return kv.Content;
                    }
                }
            }
        }

        public int IndexOf(string item)
        {
            var props = _Object._LocalProperties;

            var i = 0;
            if (props != null)
            {
                foreach (var kv in props)
                {
                    if (kv.Property.MachesChildPath(_Object.Path, _Property))
                    {
                        if (kv.Content == item)
                        {
                            return i;
                        }
                        i++;
                    }
                }
            }
            return -1;
        }

        public void Insert(int index, string item)
        {
            var props = _Object._LocalProperties;

            var j = 0;
            if (props != null)
            {
                for (int i = 0; i < props.Count; i++)
                {
                    var kv = props[i];
                    if (kv.Property.MachesChildPath(_Object.Path, _Property) && j++ == index)
                    {
                        props.Insert(i, new GraphProperty(_Object.Path + ":" + _Property, item));
                        return;
                    }
                }
            }
            if (index == j)
            {
                _Object.LocalProperties.Add(new GraphProperty(_Object.Path + ":" + _Property, item));
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public bool Remove(string item)
        {
            var props = _Object._LocalProperties;

            if (props != null)
            {
                for (int i = 0; i < props.Count; i++)
                {
                    var kv = props[i];
                    if (kv.Property.MachesChildPath(_Object.Path, _Property) && kv.Content == item)
                    {
                        props.RemoveAt(i);
                        return true;
                    }
                }
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            var props = _Object._LocalProperties;

            var j = 0;
            if (props != null)
            {
                for (int i = 0; i < props.Count; i++)
                {
                    var kv = props[i];
                    if (kv.Property.MachesChildPath(_Object.Path, _Property))
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

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}