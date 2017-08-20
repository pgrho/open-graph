using System.Collections;
using System.Collections.Generic;

namespace Shipwreck.OpenGraph.Internal
{
    internal struct WrappedGraphPropertyEnumerator : IGraphPropertyEnumerator
    {
        private IEnumerator<GraphProperty> _Enumerator;
        private NamespaceCollection _Namespaces;

        public WrappedGraphPropertyEnumerator(IEnumerable<GraphProperty> enumerable, NamespaceCollection namespaces = null)
        {
            _Enumerator = enumerable.GetEnumerator();
            _Namespaces = namespaces ?? NamespaceCollection.Default;
        }

        public GraphProperty Current
            => _Enumerator?.Current ?? default(GraphProperty);

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