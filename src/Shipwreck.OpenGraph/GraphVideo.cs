using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed partial class GraphVideo : GraphObject
    {
        public GraphVideo()
            : this("og")
        {
        }

        internal GraphVideo(string path)
            : base(path)
        {
        }

        [DefaultValue(null)]
        public string Url { get; set; }

        [DefaultValue(null)]
        public string SecureUrl { get; set; }

        [DefaultValue(null)]
        public string Type { get; set; }

        [DefaultValue(0)]
        public int Width { get; set; }

        [DefaultValue(0)]
        public int Height { get; set; }

        [DefaultValue(null)]
        public string Alt { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            child = null;
            switch (property)
            {
                case "og:video:url":
                    if (string.IsNullOrEmpty(Url))
                    {
                        Url = content;
                    }
                    else
                    {
                        return false;
                    }
                    return true;

                case "og:video:secure_url":
                    if (string.IsNullOrEmpty(SecureUrl))
                    {
                        SecureUrl = content;
                    }
                    return true;

                case "og:video:type":
                    if (string.IsNullOrEmpty(Type))
                    {
                        Type = content;
                    }
                    return true;

                case "og:video:width":
                    if (Width == 0 && int.TryParse(content, out int w))
                    {
                        Width = w;
                    }
                    return true;

                case "og:video:height":
                    if (Height == 0 && int.TryParse(content, out int h))
                    {
                        Height = h;
                    }
                    return true;

                case "og:video:alt":
                    if (string.IsNullOrEmpty(Alt))
                    {
                        Alt = content;
                    }
                    return true;
            }

            child = null;
            return false;
        }
    }
}