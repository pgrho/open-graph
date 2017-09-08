using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using Shipwreck.OpenGraph.Internal;

namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a root object of Open Graph.
    /// </summary>
    public sealed partial class Graph : GraphObject
    {
        private GraphObject _TypeObject;

        /// <summary>
        /// Initializes a new instance of the <see cref="Graph" /> class.
        /// </summary>
        public Graph()
            : base(new PropertyPath(NamespaceCollection.OpenGraph))
        {
        }

        /// <summary>
        /// Gets a type specific <see cref="GraphObject" />.
        /// </summary>
        public GraphObject TypeObject
        {
            get => _TypeObject;
            private set
            {
                if (value != _TypeObject)
                {
                    if (value?.Parent != null)
                    {
                        throw new InvalidOperationException("Specified item is already attached to an object.");
                    }

                    if (_TypeObject != null)
                    {
                        _TypeObject.Parent = null;
                    }

                    _TypeObject = value;

                    if (_TypeObject != null)
                    {
                        _TypeObject.Parent = this;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets a first value of the specified property.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public string this[PropertyPath property]
        {
            get => GetLocalProperty(property);
            set => SetLocalProperty(property, value);
        }

        #region Namespaces

        private NamespaceCollection _Namespaces;

        /// <summary>
        /// Gets the namespace collection that was used to load this graph.
        /// </summary>
        public NamespaceCollection Namespaces
        {
            get => _Namespaces ?? NamespaceCollection.Default;
            internal set => _Namespaces = value;
        }

        /// <summary>
        /// Returns whether serialization processes should serialize the contents of the <see cref="Namespaces"/> property on instances of this class.
        /// </summary>
        /// <returns><c>true</c> if the <see cref="Namespaces"/> property value should be serialized; otherwise, <c>false</c>.</returns>
        public bool ShouldSerializeNamespaces()
            => _Namespaces != null;

        #endregion Namespaces

        /// <summary>
        /// Returns a first value of the specified property.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public string GetLocalProperty(PropertyPath property)
        {
            if (property.IsRelative)
            {
                return GetLocalProperty(property.Path);
            }
            return _LocalProperties
                        ?.FirstOrDefault(kv => property.EqualsWithBasePath(kv.Property, Path))
                        .Content;
        }

        /// <summary>
        /// Removes current <see cref="GraphObject.LocalProperties"/> items that path is <paramref name="property"/> and adds a item that value is <paramref name="content"/>.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <param name="content">A new value to set.</param>
        public void SetLocalProperty(PropertyPath property, string content)
        {
            if (_LocalProperties != null)
            {
                for (int i = _LocalProperties.Count - 1; i >= 0; i--)
                {
                    if (property.EqualsWithBasePath(_LocalProperties[i].Property, Path))
                    {
                        _LocalProperties.RemoveAt(i);
                    }
                }
            }
            if (content != null)
            {
                LocalProperties.Add(new PropertyEntry(property, content));
            }
        }

        #region From*** Static methods

        #region FromXml

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified XHTML text.
        /// </summary>
        /// <param name="xml">XHTML text that contains Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXml(string xml)
            => FromXml(xml, null);

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified XHTML text and the <see cref="NamespaceCollection"/>.
        /// </summary>
        /// <param name="xml">XHTML text that contains Open Graph.</param>
        /// <param name="namespaces">The <see cref="NamespaceCollection"/> to use.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXml(string xml, NamespaceCollection namespaces)
        {
            using (var sr = new StringReader(xml))
            using (var xr = XmlReader.Create(sr))
            {
                return FromXmlReader(xr, namespaces);
            }
        }

        #endregion FromXml

        #region FromStream

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified data stream.
        /// </summary>
        /// <param name="stream">A <see cref="Stream"/> that contains the XHTML for Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromStream(Stream stream)
            => FromStream(stream, null);

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified data stream and the <see cref="NamespaceCollection"/>.
        /// </summary>
        /// <param name="stream">A <see cref="Stream"/> that contains the XHTML for Open Graph.</param>
        /// <param name="namespaces">The <see cref="NamespaceCollection"/> to use.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromStream(Stream stream, NamespaceCollection namespaces)
        {
            using (var xr = XmlReader.Create(stream, new XmlReaderSettings()
            {
                CloseInput = false
            }))
            {
                return FromXmlReader(xr, namespaces);
            }
        }

        #endregion FromStream

        #region FromTextReader

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="TextReader"/>.
        /// </summary>
        /// <param name="textReader">A <see cref="TextReader"/> that contains the XHTML for Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromTextReader(TextReader textReader)
            => FromTextReader(textReader, null);

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="TextReader"/> and the <see cref="NamespaceCollection"/>.
        /// </summary>
        /// <param name="textReader">A <see cref="TextReader"/> that contains the XHTML for Open Graph.</param>
        /// <param name="namespaces">The <see cref="NamespaceCollection"/> to use.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromTextReader(TextReader textReader, NamespaceCollection namespaces)
        {
            using (var xr = XmlReader.Create(textReader, new XmlReaderSettings()
            {
                CloseInput = false
            }))
            {
                return FromXmlReader(xr, namespaces);
            }
        }

        #endregion FromTextReader

        #region FromXmlReader

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="XmlReader"/>.
        /// </summary>
        /// <param name="xmlReader">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXmlReader(XmlReader xmlReader)
            => FromXmlReader(xmlReader, null);

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="XmlReader"/> and the <see cref="NamespaceCollection"/>.
        /// </summary>
        /// <param name="xmlReader">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <param name="namespaces">The <see cref="NamespaceCollection"/> to use.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXmlReader(XmlReader xmlReader, NamespaceCollection namespaces)
        {
            if (namespaces == NamespaceCollection.Default)
            {
                throw new ArgumentException("Can't specify the default NamespaceCollection");
            }
            var r = new Graph();
            r._Namespaces = namespaces;
            r.LoadProperties(new XmlReaderPropertyEntryEnumerator(xmlReader));
            return r;
        }

        #endregion FromXmlReader

        #region FromXmlDocument

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="XmlDocument"/>.
        /// </summary>
        /// <param name="xmlDocument">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXmlDocument(XmlDocument xmlDocument)
            => FromXmlDocument(xmlDocument, null);

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="XmlDocument"/> and the <see cref="NamespaceCollection"/>.
        /// </summary>
        /// <param name="xmlDocument">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <param name="namespaces">The <see cref="NamespaceCollection"/> to use.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
#if NETSTANDARD1_3

        public static Graph FromXmlDocument(XmlDocument xmlDocument, NamespaceCollection namespaces)
        {
            if (namespaces == NamespaceCollection.Default)
            {
                throw new ArgumentException("Can't specify the default NamespaceCollection");
            }
            var r = new Graph();
            r._Namespaces = namespaces;
            r.LoadProperties(new XmlDocumentPropertyEntryEnumerator(xmlDocument));
            return r;
        }

#else
        public static Graph FromXmlDocument(XmlDocument xmlDocument, NamespaceCollection namespaces)
        {
            using (var r = new XmlNodeReader(xmlDocument))
            {
                return FromXmlReader(r, namespaces);
            }
        }
#endif

        #endregion FromXmlDocument

        #region FromXPathNavigable

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="IXPathNavigable"/>.
        /// </summary>
        /// <param name="xPathNavigable">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXPathNavigable(IXPathNavigable xPathNavigable)
            => FromXPathNavigable(xPathNavigable, null);

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="IXPathNavigable"/> and the <see cref="NamespaceCollection"/>.
        /// </summary>
        /// <param name="xPathNavigable">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <param name="namespaces">The <see cref="NamespaceCollection"/> to use.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXPathNavigable(IXPathNavigable xPathNavigable, NamespaceCollection namespaces)
            => FromXPathNavigator(xPathNavigable.CreateNavigator(), namespaces);

        #endregion FromXPathNavigable

        #region FromXPathNavigator

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="XPathNavigator"/>.
        /// </summary>
        /// <param name="xPathNavigator">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXPathNavigator(XPathNavigator xPathNavigator)
            => FromXPathNavigator(xPathNavigator, null);

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="XPathNavigator"/> and the <see cref="NamespaceCollection"/>.
        /// </summary>
        /// <param name="xPathNavigator">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <param name="namespaces">The <see cref="NamespaceCollection"/> to use.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXPathNavigator(XPathNavigator xPathNavigator, NamespaceCollection namespaces)
        {
            // prefetch namespaces due to XPathNavigator's poor implementation.
            var html = xPathNavigator.SelectSingleNode("//*[local-name()='html' or local-name()='HTML' or local-name()='Html']");
            if (html != null)
            {
                var head = html.SelectSingleNode("*[local-name()='head' or local-name()='HEAD' or local-name()='head']");

                while (html.MoveToNextAttribute())
                {
                    if (html.LocalName.StartsWith("xmlns:"))
                    {
                        (namespaces ?? (namespaces = new NamespaceCollection()))[html.LocalName.Substring(6)] = html.Value;
                    }
                }

                if (head != null)
                {
                    while (head.MoveToNextAttribute())
                    {
                        if (head.LocalName.StartsWith("xmlns:"))
                        {
                            (namespaces ?? (namespaces = new NamespaceCollection()))[head.LocalName.Substring(6)] = head.Value;
                        }
                    }
                }
            }

            xPathNavigator.MoveToRoot();

            using (var r = xPathNavigator.ReadSubtree())
            {
                return FromXmlReader(r, namespaces);
            }
        }

        #endregion FromXPathNavigator

        #endregion From*** Static methods

        /// <inheritdoc />
        internal override bool TryAddMetadata(PropertyPath property, string content, out GraphObject targetObject)
        {
            if (property.StartsWith(Path))
            {
                if (property.Equals(Path, "type"))
                {
                    if (Type == null)
                    {
                        Type = content;

                        _TypeObject = CreateTypeObject();
                        if (_TypeObject != null)
                        {
                            _TypeObject.Parent = this;

                            if (ShouldSerializeLocalProperties())
                            {
                                List<int> removed = null;
                                _TypeObject.LoadProperties(new WrappedPropertyEntryEnumerator(GetLocalProperties().Where((kv, i) =>
                                {
                                    if (kv.Property == _TypeObject.Path)
                                    {
                                        _TypeObject.Url = _TypeObject.Url ?? kv.Content;
                                        (removed ?? (removed = new List<int>())).Add(i);
                                        return false;
                                    }
                                    if (kv.Property.StartsWith(_TypeObject.Path))
                                    {
                                        (removed ?? (removed = new List<int>())).Add(i);
                                        return true;
                                    }
                                    return false;
                                }), Namespaces));

                                for (var i = (removed?.Count ?? 0) - 1; i >= 0; i--)
                                {
                                    LocalProperties.RemoveAt(removed[i]);
                                }
                            }
                        }
                    }

                    targetObject = this;
                    return true;
                }
            }

            if (_TypeObject != null)
            {
                if (_TypeObject.TryAddMetadata(property, content, out targetObject) == true)
                {
                    return true;
                }
                if (property == _TypeObject.Path)
                {
                    _TypeObject.Url = _TypeObject.Url ?? content;
                }
            }

            return base.TryAddMetadata(property, content, out targetObject);
        }

        /// <inheritdoc />
        public override IEnumerator<PropertyEntry> GetEnumerator()
        {
            using (var iter = base.GetEnumerator())
            {
                while (iter.MoveNext())
                {
                    yield return iter.Current;
                }
            }

            if (_TypeObject != null)
            {
                foreach (var kv in _TypeObject)
                {
                    yield return kv;
                }
            }
        }

        #region Output Methods

        #region Get Namespaces

        /// <summary>
        /// Returns a sequence of namespace URI that is needed to describe this graph.
        /// </summary>
        /// <returns>A  sequence of namespace URI.</returns>
        public IEnumerable<string> GetNamespaces()
        {
            List<string> ns = null;

            void addNamespace(PropertyPath p)
            {
                var v = p.Namespace ?? Path.Namespace;
                if (ns == null)
                {
                    ns = new List<string>(4);
                    ns.Add(v);
                }
                else if (!ns.Contains(v))
                {
                    ns.Add(v);
                }
            }

            if (_LocalProperties != null)
            {
                foreach (var kv in _LocalProperties)
                {
                    addNamespace(kv.Property);
                }
            }

            if (_Children != null)
            {
                foreach (var c in _Children)
                {
                    addNamespace(c.Path);
                }
            }
            if (_TypeObject != null)
            {
                addNamespace(_TypeObject.Path);
            }

            return ns ?? Enumerable.Empty<string>();
        }

        /// <summary>
        /// Returns a prefix attribute value that is needed to describe this graph.
        /// </summary>
        /// <returns>A string that defines all namespaces used by this instance.</returns>
        public string GetPrefixAttribute()
        {
            StringBuilder sb = null;

            foreach (var n in GetNamespaces())
            {
                var p = Namespaces.GetPrefix(n);
                if (p != null)
                {
                    if (sb == null)
                    {
                        sb = new StringBuilder(64);
                    }
                    else
                    {
                        sb.Append(' ');
                    }
                    sb.Append(p).Append(':').Append(n);
                }
            }

            return sb.Length > 0 ? sb.ToString() : null;
        }

        #endregion Get Namespaces

        #region WriteTo

        private const string XHTML_NS = "http://www.w3.org/1999/xhtml";

        /// <summary>
        /// Writes HTML <c>%lt;meta&gt;</c> elements that represents this graph to the specified <see cref="TextWriter"/>.
        /// </summary>
        /// <param name="writer">The <see cref="TextWriter" /> to be written.</param>
        public void WriteTo(TextWriter writer)
        {
            using (var xw = XmlWriter.Create(writer, new XmlWriterSettings()
            {
                CloseOutput = true,
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Fragment
            }))
            {
                WriteXmlTo(xw);
            }
        }

        /// <summary>
        /// Asynchronously writes HTML <c>%lt;meta&gt;</c> elements that represents this graph to the specified <see cref="TextWriter"/>.
        /// </summary>
        /// <param name="writer">The <see cref="TextWriter" /> to be written.</param>
        /// <returns>A task that represents the asynchronous copy operation.</returns>
        public async Task WriteToAsync(TextWriter writer)
        {
            using (var xw = XmlWriter.Create(writer, new XmlWriterSettings()
            {
                CloseOutput = true,
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Fragment
            }))
            {
                await WriteXmlToAsync(xw).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Writes HTML <c>%lt;meta&gt;</c> elements that represents this graph to the specified <see cref="XmlWriter"/>.
        /// </summary>
        /// <param name="writer">The <see cref="XmlWriter" /> to be written.</param>
        /// <param name="isXhtml">The value injdicating whether output xhtml xmlns.</param>
        public void WriteXmlTo(XmlWriter writer, bool isXhtml = false)
        {
            foreach (var gp in this)
            {
                writer.WriteStartElement("meta", isXhtml ? XHTML_NS : null);
                var path = gp.Property;
                writer.WriteAttributeString("property", GetPrefixWithColon(path.Namespace) + path.Path);
                writer.WriteAttributeString("content", gp.Content);

                writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Asynchronously writes HTML <c>%lt;meta&gt;</c> elements that represents this graph to the specified <see cref="XmlWriter"/>.
        /// </summary>
        /// <param name="writer">The <see cref="XmlWriter" /> to be written.</param>
        /// <param name="isXhtml">The value injdicating whether output xhtml xmlns.</param>
        /// <returns>A task that represents the asynchronous copy operation.</returns>
        public async Task WriteXmlToAsync(XmlWriter writer, bool isXhtml = false)
        {
            foreach (var gp in this)
            {
                await writer.WriteStartElementAsync(null, "meta", isXhtml ? XHTML_NS : null).ConfigureAwait(false);

                var path = gp.Property;
                await writer.WriteAttributeStringAsync(null, "property", null, GetPrefixWithColon(path.Namespace) + path.Path).ConfigureAwait(false);
                await writer.WriteAttributeStringAsync(null, "content", null, gp.Content).ConfigureAwait(false);

                await writer.WriteEndElementAsync().ConfigureAwait(false);
            }
        }

        private string GetPrefixWithColon(string @namespace)
        {
            var prefix = Namespaces.GetPrefix(@namespace);

            if (prefix == null)
            {
                prefix = @namespace != null ? $"{{{@namespace}}}:" : null;
            }
            else
            {
                prefix += ":";
            }

            return prefix;
        }

        #endregion WriteTo

        /// <summary>
        /// Returns a sequence of HTML <c>%lt;meta&gt;</c> elements that represents this graph.
        /// </summary>
        /// <param name="xmlDocument">The <see cref="XmlDocument" /> to create elements.</param>
        /// <param name="isXhtml">The value injdicating whether output xhtml xmlns.</param>
        public IEnumerable<XmlElement> EnumerateMetaElements(XmlDocument xmlDocument, bool isXhtml = false)
        {
            foreach (var pe in this)
            {
                var e = xmlDocument.CreateElement(null, "meta", isXhtml ? XHTML_NS : null);

                var path = pe.Property;
                e.SetAttribute("property", GetPrefixWithColon(path.Namespace) + path.Path);
                e.SetAttribute("content", pe.Content);

                yield return e;
            }
        }

        #endregion Output Methods
    }
}