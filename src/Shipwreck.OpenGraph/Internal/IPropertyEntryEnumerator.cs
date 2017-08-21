using System.Collections.Generic;

namespace Shipwreck.OpenGraph.Internal
{
    internal interface IPropertyEntryEnumerator : IEnumerator<PropertyEntry>
    {
        NamespaceCollection Namespaces { get; }
    }
}