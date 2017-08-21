using System;
using System.Collections;
using System.Xml;

namespace Shipwreck.OpenGraph.Internal
{
    internal struct XmlReaderGraphPropertyEnumerator : IGraphPropertyEnumerator
    {
        private enum State : byte
        {
            NONE,
            HTML,
            HEAD,
            META,
            END
        }

        private XmlReader _Reader;
        private byte _Level;
        private State _State;
        private string _Property;
        private string _Content;
        private NamespaceCollection _Namespaces;

        public XmlReaderGraphPropertyEnumerator(XmlReader reader)
        {
            _Reader = reader;
            _Level = 0;
            _State = State.NONE;
            _Property = _Content = null;
            _Namespaces = null;
        }

        public GraphProperty Current
            => new GraphProperty(new PropertyPath(null, _Property), _Content);

        object IEnumerator.Current
            => Current;

        public NamespaceCollection Namespaces
            => _Namespaces ?? NamespaceCollection.Default;

        public void Dispose()
        {
            _Reader = null;
        }

        public bool MoveNext()
        {
            if (_State != State.END)
            {
                while (_Reader.Read())
                {
                    switch (_Reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            var isEmpty = _Reader.IsEmptyElement;

                            switch (++_Level)
                            {
                                case 1:
                                    _State = "html".Equals(_Reader.LocalName, StringComparison.OrdinalIgnoreCase) ? State.HTML : State.NONE;
                                    if (_State == State.HTML)
                                    {
                                        ReadNamespaces();
                                    }
                                    break;

                                case 2:
                                    _State = "head".Equals(_Reader.LocalName, StringComparison.OrdinalIgnoreCase) ? State.HEAD : _State;
                                    if (_State == State.HEAD)
                                    {
                                        ReadNamespaces();
                                        (_Namespaces ?? (_Namespaces = new NamespaceCollection())).LoadNameTable(_Reader.NameTable);
                                    }
                                    break;

                                case 3:
                                    if (_State == State.HEAD && "meta".Equals(_Reader.LocalName, StringComparison.OrdinalIgnoreCase))
                                    {
                                        _Property = _Reader.GetAttribute("property");
                                        _Content = _Reader.GetAttribute("content");
                                        if (!string.IsNullOrEmpty(_Property))
                                        {
                                            _State = State.META;
                                        }
                                    }
                                    break;
                            }

                            if (isEmpty)
                            {
                                _Level--;

                                if (_State == State.META)
                                {
                                    _State = State.HEAD;
                                    return true;
                                }
                            }

                            break;

                        case XmlNodeType.EndElement:

                            if (_Level == 3 && _State == State.META)
                            {
                                _State = State.HEAD;
                            }
                            else if (_Level == 2 && _State == State.HEAD)
                            {
                                _State = State.END;
                            }
                            _Level--;
                            break;
                    }
                }
            }
            _Property = _Content = null;
            return false;
        }

        void IEnumerator.Reset()
            => throw new NotSupportedException();

        private void ReadNamespaces()
            => (_Namespaces ?? (_Namespaces = new NamespaceCollection())).LoadPrefixAttribute(_Reader.GetAttribute("prefix"));
    }
}