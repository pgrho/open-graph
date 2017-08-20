using System.Collections.Generic;

namespace Shipwreck.OpenGraph.Internal
{
    internal interface IGraphPropertyEnumerator : IEnumerator<GraphProperty>
    {
        NamespaceCollection Namespaces { get; }
    }
}