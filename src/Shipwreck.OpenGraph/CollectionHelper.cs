using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Shipwreck.OpenGraph
{
    internal static class CollectionHelper
    {
        public static List<T> GetCollection<T>(ref List<T> collection)
            => collection ?? (collection = new List<T>());

        public static void SetCollection<T>(ref List<T> collection, ICollection<T> value)
        {
            if (value != collection)
            {
                collection?.Clear();
                if (value?.Count > 0)
                {
                    if (collection == null)
                    {
                        collection = new List<T>();
                    }
                    foreach (var v in value)
                    {
                        collection.Add(v);
                    }
                }
            }
        }
    }
}