using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Shipwreck.OpenGraph
{
    internal static class CollectionHelper
    {
        public static Collection<T> GetCollection<T>(ref Collection<T> collection)
            => collection ?? (collection = new Collection<T>(new List<T>(1)));

        public static void SetCollection<T>(ref Collection<T> collection, ICollection<T> value)
        {
            if (value != collection)
            {
                collection?.Clear();
                if (value?.Count > 0)
                {
                    if (collection == null)
                    {
                        collection = new Collection<T>(new List<T>(1));
                    }
                    foreach (var v in value)
                    {
                        collection.Add(v);
                    }
                }
            }
        }

        public static void SetCollection<T>(ref Collection<T> collection, T value)
        {
            collection?.Clear();
            if (value != null)
            {
                if (collection == null)
                {
                    collection = new Collection<T>(new List<T>(1));
                }
                collection.Add(value);
            }
        }
    }
}