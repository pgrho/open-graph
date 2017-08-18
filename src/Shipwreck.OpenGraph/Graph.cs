using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml;

namespace Shipwreck.OpenGraph
{
    public sealed partial class Graph : GraphObject
    {
        private GraphObject _TypeObject;

        public Graph()
            : base("og")
        {
        }

        internal override bool IsRoot => true;

        [DefaultValue(null)]
        public string Type { get; set; }

        public GraphObject TypeObject => _TypeObject;

        public static Graph FromXml(string xml)
        {
            using (var sr = new StringReader(xml))
            using (var xr = XmlReader.Create(sr))
            {
                return FromXmlReader(xr);
            }
        }

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

        public static Graph FromXmlReader(XmlReader xmlReader)
        {
            var r = new Graph();
            r.LoadProperties(Enumerate(xmlReader));
            return r;
        }

        private static IEnumerable<GraphProperty> Enumerate(XmlReader reader)
        {
            var nest = 0;

            var isHtml = false;
            var isHead = false;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:

                        var isEmpty = reader.IsEmptyElement;

                        switch (++nest)
                        {
                            case 1:
                                isHtml = "html".Equals(reader.LocalName, StringComparison.OrdinalIgnoreCase);
                                break;

                            case 2:
                                isHead = isHtml && "head".Equals(reader.LocalName, StringComparison.OrdinalIgnoreCase);
                                break;

                            case 3:
                                if (isHead && "meta".Equals(reader.LocalName, StringComparison.OrdinalIgnoreCase))
                                {
                                    if (reader.MoveToAttribute("property"))
                                    {
                                        var prop = reader.Value;
                                        if (reader.MoveToAttribute("content"))
                                        {
                                            yield return new GraphProperty(prop, reader.Value);
                                        }
                                    }
                                }
                                break;
                        }

                        if (isEmpty)
                        {
                            nest--;
                        }

                        break;

                    case XmlNodeType.EndElement:
                        if (--nest <= 1 && isHead)
                        {
                            yield break;
                        }
                        break;
                }
            }
        }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            child = null;
            if (property.MachesPath(Path))
            {
                if (property.MachesChildPath(Path, "type"))
                {
                    if (Type == null)
                    {
                        Type = content;

                        switch (content)
                        {
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

                            case "article":
                                Article = new Article();
                                break;

                            case "book":
                                Book = new Book();
                                break;

                            case "profile":
                                Profile = new Profile();
                                break;
                        }

                        if (_TypeObject != null && ShouldSerializeExtraProperties())
                        {
                            _TypeObject.LoadProperties(ExtraProperties.Where(kv =>
                            {
                                if (kv.Property == _TypeObject.Path)
                                {
                                    _TypeObject.Url = _TypeObject.Url ?? kv.Content;
                                    return false;
                                }
                                return kv.Property.MachesPath(_TypeObject.Path);
                            }));

                            for (var i = ExtraProperties.Count - 1; i >= 0; i--)
                            {
                                var p = ExtraProperties[i].Property;
                                if (p.MachesPath(_TypeObject.Path)
                                    || p == _TypeObject.Path)
                                {
                                    ExtraProperties.RemoveAt(i);
                                }
                            }
                        }
                    }

                    return true;
                }
            }

            if (_TypeObject != null)
            {
                if (_TypeObject.TryAddMetadata(property, content, out child) == true)
                {
                    return true;
                }
                if (property == _TypeObject.Path)
                {
                    _TypeObject.Url = _TypeObject.Url ?? content;
                }
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}