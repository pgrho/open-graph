using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Shipwreck.OpenGraph
{
    public sealed partial class Graph : GraphObject
    {
        public static Graph FromXml(string xml)
        {
            using (var sr = new StringReader(xml))
            using (var xr = XmlReader.Create(sr))
            {
                return FromReader(xr);
            }
        }

        public static Graph FromReader(XmlReader reader)
        {
            var nest = 0;

            var isHtml = false;
            var isHead = false;

            var r = new Graph();
            var stack = new List<GraphObject>(2);
            stack.Add(r);

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
                                            var content = reader.Value;

                                            for (int i = stack.Count - 1; i >= 0; i--)
                                            {
                                                var obj = stack[i];

                                                if (obj.TryAddMetadata(prop, content, out GraphObject c))
                                                {
                                                    stack.RemoveRange(i + 1, stack.Count - i - 1);

                                                    if (c != null)
                                                    {
                                                        stack.Add(c);
                                                    }
                                                    break;
                                                }
                                            }
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
                            return r;
                        }
                        break;
                }
            }

            return r;
        }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (property.StartsWith("og:image:"))
            {
                var img = new GraphImage();
                Images.Add(img);
                child = img;
                child.TryAddMetadata(property, content, out _);
                return true;
            }

            if (property.StartsWith("og:video:"))
            {
                var img = new GraphVideo();
                Videos.Add(img);
                child = img;
                child.TryAddMetadata(property, content, out _);
                return true;
            }

            switch (property)
            {
                case "og:title":
                    Titles.Add(content);
                    child = null;
                    return true;

                case "og:type":
                    Types.Add(content);
                    child = null;
                    return true;

                case "og:description":
                    Descriptions.Add(content);
                    child = null;
                    return true;

                case "og:determiner":
                    Determiners.Add(content);
                    child = null;
                    return true;

                case "og:url":
                    Urls.Add(content);
                    child = null;
                    return true;

                case "og:image":
                    var img = new GraphImage() { Url = content };
                    Images.Add(img);
                    child = img;
                    return true;

                case "og:locale":
                    Locales.Add(content);
                    child = null;
                    return true;

                case "og:locale:alternate":
                    AlternateLocales.Add(content);
                    child = null;
                    return true;

                case "og:site_name":
                    SiteNames.Add(content);
                    child = null;
                    return true;

                case "og:video":
                    var v = new GraphVideo() { Url = content };
                    Videos.Add(v);
                    child = v;
                    return true;
            }

            child = null;
            return false;
        }
    }
}