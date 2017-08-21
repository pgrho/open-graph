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
        /// Creates a <see cref="Graph" /> from the specified XHTML text.
        /// </summary>
        /// <param name="xml">XHTML text that contains Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXml(string xml)
        {
            using (var sr = new StringReader(xml))
            using (var xr = XmlReader.Create(sr))
            {
                return FromXmlReader(xr);
            }
        }

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified data stream.
        /// </summary>
        /// <param name="stream">A <see cref="Stream"/> that contains the XHTML for Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromStream(Stream stream)
        {
            using (var xr = XmlReader.Create(stream, new XmlReaderSettings()
            {
                CloseInput = false
            }))
            {
                return FromXmlReader(xr);
            }
        }

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="TextReader"/>.
        /// </summary>
        /// <param name="textReader">A <see cref="TextReader"/> that contains the XHTML for Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromTextReader(TextReader textReader)
        {
            using (var xr = XmlReader.Create(textReader, new XmlReaderSettings()
            {
                CloseInput = false
            }))
            {
                return FromXmlReader(xr);
            }
        }

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="XmlReader"/>.
        /// </summary>
        /// <param name="xmlReader">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXmlReader(XmlReader xmlReader)
        {
            var r = new Graph();
            r.LoadProperties(new XmlReaderGraphPropertyEnumerator(xmlReader));
            return r;
        }

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="XmlDocument"/>.
        /// </summary>
        /// <param name="xmlDocument">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
#if NETSTANDARD1_3

        public static Graph FromXmlDocument(XmlDocument xmlDocument)
        {
            var r = new Graph();
            r.LoadProperties(new XmlDocumentGraphPropertyEnumerator(xmlDocument));
            return r;
        }

#else
        public static Graph FromXmlDocument(XmlDocument xmlDocument)
        {
            using (var r = new XmlNodeReader(xmlDocument))
            {
                return FromXmlReader(r);
            }
        }
#endif

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="IXPathNavigable"/>.
        /// </summary>
        /// <param name="xPathNavigable">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXPathNavigable(IXPathNavigable xPathNavigable)
            => FromXPathNavigator(xPathNavigable.CreateNavigator());

        /// <summary>
        /// Creates a <see cref="Graph" /> from the specified <see cref="XPathNavigator"/>.
        /// </summary>
        /// <param name="xPathNavigator">A <see cref="XmlReader"/> that contains the Open Graph.</param>
        /// <returns>The <see cref="Graph" /> this method creates.</returns>
        public static Graph FromXPathNavigator(XPathNavigator xPathNavigator)
        {
            using (var r = xPathNavigator.ReadSubtree())
            {
                return FromXmlReader(r);
            }
        }

        /// <inheritdoc />
        internal override bool TryAddMetadata(PropertyPath property, string content)
        {
            if (property.StartsWith(Path))
            {
                if (property.Equals(Path, "type"))
                {
                    if (Type == null)
                    {
                        Type = content;

                        switch (content)
                        {
                            case "article":
                                Article = new Article();
                                break;

                            case "book":
                                Book = new Book();
                                break;

                            case "books.author":
                                Profile = new Profile(new PropertyPath(NamespaceCollection.Books));
                                break;

                            case "books.book":
                                Book = new Book(new PropertyPath(NamespaceCollection.Books));
                                break;

                            case "books.genre":
                                BookGenre = new BookGenre();
                                break;

                            case "music.song":
                                MusicSong = new MusicSong();
                                break;

                            case "music.album":
                                MusicAlbum = new MusicAlbum();
                                break;

                            case "music.playlist":
                                MusicPlaylist = new MusicPlaylist();
                                break;

                            case "music.radio_station":
                                MusicRadioStation = new MusicRadioStation();
                                break;

                            case "profile":
                                Profile = new Profile();
                                break;

                            case "video.movie":
                                VideoMovie = new VideoMovie();
                                break;

                            case "video.episode":
                                VideoEpisode = new VideoEpisode();
                                break;

                            case "video.tv_show":
                                VideoTVShow = new VideoTVShow();
                                break;

                            case "video.other":
                                VideoOther = new VideoOther();
                                break;
                        }

                        if (_TypeObject != null && ShouldSerializeLocalProperties())
                        {
                            _TypeObject.LoadProperties(new WrappedGraphPropertyEnumerator(LocalProperties.Where(kv =>
                            {
                                if (kv.Property == _TypeObject.Path)
                                {
                                    _TypeObject.Url = _TypeObject.Url ?? kv.Content;
                                    return false;
                                }
                                return kv.Property.StartsWith(_TypeObject.Path);
                            }), Namespaces));

                            for (var i = LocalProperties.Count - 1; i >= 0; i--)
                            {
                                var p = LocalProperties[i].Property;
                                if (p.StartsWith(_TypeObject.Path))
                                {
                                    LocalProperties.RemoveAt(i);
                                }
                            }
                        }
                    }

                    return true;
                }
            }

            if (_TypeObject != null)
            {
                if (_TypeObject.TryAddMetadata(property, content) == true)
                {
                    return true;
                }
                if (property == _TypeObject.Path)
                {
                    _TypeObject.Url = _TypeObject.Url ?? content;
                }
            }

            return base.TryAddMetadata(property, content);
        }

        /// <inheritdoc />
        public override IEnumerator<GraphProperty> GetEnumerator()
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

        /// <summary>
        /// Returns a prefix attribute value that is needed to describe this graph.
        /// </summary>
        /// <returns>A string that defines all namespaces used by this instance.</returns>
        public string GetPrefixAttribute()
        {
            List<string> ns = null;

            void addNamespace(PropertyPath p)
            {
                if (p.Namespace != null)
                {
                    if (ns == null)
                    {
                        ns = new List<string>(4);
                        ns.Add(p.Namespace);
                    }
                    else if (!ns.Contains(p.Namespace))
                    {
                        ns.Add(p.Namespace);
                    }
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

            if (ns == null)
            {
                return null;
            }
            var sb = new StringBuilder(32);

            foreach (var n in ns)
            {
                var p = Namespaces.GetPrefix(n);
                if (p != null)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(' ');
                    }
                    sb.Append(p).Append(':').Append(n);
                }
            }

            return sb.Length > 0 ? sb.ToString() : null;
        }

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
                WriteTo(xw);
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
                await WriteToAsync(xw).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Writes HTML <c>%lt;meta&gt;</c> elements that represents this graph to the specified <see cref="XmlWriter"/>.
        /// </summary>
        /// <param name="writer">The <see cref="XmlWriter" /> to be written.</param>
        /// <param name="isXhtml">The value injdicating whether output xhtml xmlns.</param>
        public void WriteTo(XmlWriter writer, bool isXhtml = false)
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
        public async Task WriteToAsync(XmlWriter writer, bool isXhtml = false)
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
    }
}