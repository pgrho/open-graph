using System.Collections;
using System.Collections.Generic;

namespace Shipwreck.OpenGraph.Internal
{
    internal struct WrappedPropertyEntryEnumerator : IPropertyEntryEnumerator
    {
        private IEnumerator<PropertyEntry> _Enumerator;
        private NamespaceCollection _Namespaces;

        public WrappedPropertyEntryEnumerator(IEnumerable<PropertyEntry> enumerable, NamespaceCollection namespaces = null)
        {
            _Enumerator = enumerable.GetEnumerator();
            _Namespaces = namespaces ?? NamespaceCollection.Default;
        }

        public PropertyEntry Current
            => _Enumerator?.Current ?? default(PropertyEntry);

        object IEnumerator.Current
            => Current;

        public NamespaceCollection Namespaces
            => _Namespaces;

        public void Dispose()
        {
            _Enumerator?.Dispose();
            _Enumerator = null;
        }

        public bool MoveNext()
            => _Enumerator?.MoveNext() ?? false;

        public void Reset()
            => _Enumerator?.Reset();
    }
}