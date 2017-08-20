#if NETSTANDARD1_3

using System;
using System.Collections;
using System.Xml;

namespace Shipwreck.OpenGraph.Internal
{
    internal struct XmlDocumentGraphPropertyEnumerator : IGraphPropertyEnumerator
    {
        private XmlDocument _Document;
        private XmlElement _Head;
        private int _Index;
        private NamespaceCollection _Namespaces;

        public XmlDocumentGraphPropertyEnumerator(XmlDocument xmlDocument)
        {
            _Document = xmlDocument;
            _Head = null;
            _Index = -1;
            _Namespaces = null;
        }

        public GraphProperty Current
        {
            get
            {
                if (_Head != null && _Index < _Head.ChildNodes.Count)
                {
                    var e = (XmlElement)_Head.ChildNodes[_Index];

                    return new GraphProperty(new PropertyName(null, e.GetAttribute("property")), "content");
                }
                return default(GraphProperty);
            }
        }

        object IEnumerator.Current
            => Current;

        public NamespaceCollection Namespaces
            => _Namespaces ?? NamespaceCollection.Default;

        public void Dispose()
        {
            _Document = null;
            _Head = null;
        }

        public bool MoveNext()
        {
            if (_Head == null)
            {
                if (_Index < 0)
                {
                    _Index = 0;

                    if ("html".Equals(_Document?.DocumentElement?.LocalName, StringComparison.OrdinalIgnoreCase))
                    {
                        ReadNamespaces(_Document.DocumentElement);

                        foreach (XmlNode head in _Document.DocumentElement.ChildNodes)
                        {
                            if (head.NodeType == XmlNodeType.Element
                                && "head".Equals(head.LocalName, StringComparison.OrdinalIgnoreCase))
                            {
                                _Head = (XmlElement)head;
                                ReadNamespaces(_Head);

                                (_Namespaces ?? (_Namespaces = new NamespaceCollection())).LoadNameTable(_Document.NameTable);

                                break;
                            }
                        }
                    }
                }
            }

            if (_Head != null)
            {
                for (; _Index < _Head.ChildNodes.Count; _Index++)
                {
                    var meta = _Head.ChildNodes[_Index];
                    if (meta.NodeType == XmlNodeType.Element
                        && "meta".Equals(meta.LocalName, StringComparison.OrdinalIgnoreCase)
                        && !string.IsNullOrEmpty(meta.Attributes["property"]?.Value))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void Reset()
        {
            _Head = null;
            _Index = -1;
        }

        private void ReadNamespaces(XmlElement element)
            => (_Namespaces ?? (_Namespaces = new NamespaceCollection())).LoadPrefixAttribute(element.Attributes["prefix"]?.Value);
    }
}

#endif