using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a namespace URI and prefix mappings.
    /// </summary>
    public class NamespaceCollection
    {
        #region Constants

        /// <summary>
        /// Defined Namespace URI for Open Graph.
        /// </summary>
        public const string OpenGraph = "http://ogp.me/ns#";

        /// <summary>
        /// Defined Namespace URI for `fb.*` type.
        /// </summary>
        public const string Facebook = "http://ogp.me/ns/fb#";

        /// <summary>
        /// Defined Namespace URI for `music.*` type.
        /// </summary>
        public const string Music = "http://ogp.me/ns/music#";

        /// <summary>
        /// Defined Namespace URI for `video.*` type.
        /// </summary>
        public const string Video = "http://ogp.me/ns/video#";

        /// <summary>
        /// Defined Namespace URI for `article` type.
        /// </summary>
        public const string Article = "http://ogp.me/ns/article#";

        /// <summary>
        /// Defined Namespace URI for `book` type.
        /// </summary>
        public const string Book = "http://ogp.me/ns/book#";

        /// <summary>
        /// Defined Namespace URI for `books.*` type.
        /// </summary>
        public const string Books = "http://ogp.me/ns/books#";

        /// <summary>
        /// Defined Namespace URI for `profile` type.
        /// </summary>
        public const string Profile = "http://ogp.me/ns/profile#";

        /// <summary>
        /// Defined Namespace URI for `product` type.
        /// </summary>
        public const string Product = "http://ogp.me/ns/product#";

        /// <summary>
        /// Defined Namespace URI for `al.*` type.
        /// </summary>
        public const string Applink = "http://ogp.me/ns/al#";

        /// <summary>
        /// Defined Namespace URI for `business.*` type.
        /// </summary>
        public const string Business = "http://ogp.me/ns/business#";

        /// <summary>
        /// Defined Namespace URI for `fitness:*` types.
        /// </summary>
        public const string Fitness = "http://ogp.me/ns/fitness#";

        /// <summary>
        /// Defined Namespace URI for `game:*` types.
        /// </summary>
        public const string Game = "http://ogp.me/ns/game#";

        /// <summary>
        /// Defined Namespace URI for `place:*` properties.
        /// </summary>
        public const string Place = "http://ogp.me/ns/place#";

        #endregion Constants

        private static readonly Regex _SplitPattern = new Regex("(?<!:)\\s+");

        internal static readonly NamespaceCollection Default = new NamespaceCollection();

        private readonly Dictionary<string, string> _Map;

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceCollection" /> class with default mappings.
        /// </summary>
        public NamespaceCollection()
        {
            _Map = new Dictionary<string, string>()
            {
                ["og"] = OpenGraph,
                ["fb"] = Facebook,
                ["music"] = Music,
                ["video"] = Video,
                ["article"] = Article,
                ["book"] = Book,
                ["books"] = Books,
                ["profile"] = Profile,
                ["product"] = Product,
                ["al"] = Applink,
                ["fitness"] = Fitness,
                ["place"] = Place,
            };
        }

        /// <summary>
        /// Gets a namespace URI for the specified prefix.
        /// </summary>
        /// <param name="prefix">The prefix to get a namespace.</param>
        /// <returns>A namespace URI for <paramref name="prefix"/>.</returns>
        public string this[string prefix]
        {
            get => _Map.TryGetValue(prefix, out var s) ? s : null;
            internal set
            {
                var currentPrefix = _Map.FirstOrDefault(kv => kv.Value == value).Key;
                if (currentPrefix != prefix)
                {
                    if (currentPrefix != null)
                    {
                        _Map.Remove(currentPrefix);
                    }
                    _Map[prefix] = value;
                }
            }
        }

        /// <summary>
        /// Returns a prefix for the specified namespace URI.
        /// </summary>
        /// <param name="namespace">The namespace URI.</param>
        /// <returns>A prefix for <paramref name="namespace"/>.</returns>
        public string GetPrefix(string @namespace)
            => _Map.FirstOrDefault(kv => kv.Value == @namespace).Key;

        internal void LoadPrefixAttribute(string value)
        {
            if (value != null)
            {
                foreach (var p in _SplitPattern.Split(value))
                {
                    var i = p.IndexOf(':');
                    if (i > 0)
                    {
                        var pre = p.Substring(0, i).Trim();
                        var ns = p.Substring(i + 1).Trim();

                        if (!string.IsNullOrEmpty(pre) && !string.IsNullOrEmpty(ns))
                        {
                            this[pre] = ns;
                        }
                    }
                }
            }
        }

        internal void LoadNameTable(XmlNameTable nameTable)
        {
            var m = new XmlNamespaceManager(nameTable);
            foreach (var kv in m.GetNamespacesInScope(XmlNamespaceScope.ExcludeXml))
            {
                this[kv.Key] = kv.Value;
            }
        }
    }
}