using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed partial class GraphAudio : GraphObject
    {
        [DefaultValue(null)]
        public string Url { get; set; }

        [DefaultValue(null)]
        public string SecureUrl { get; set; }

        [DefaultValue(null)]
        public string Type { get; set; }
         
        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            child = null;
            switch (property)
            {
                case "og:audio:url":
                    if (string.IsNullOrEmpty(Url))
                    {
                        Url = content;
                    }
                    else
                    {
                        return false;
                    }
                    return true;

                case "og:audio:secure_url":
                    if (string.IsNullOrEmpty(SecureUrl))
                    {
                        SecureUrl = content;
                    }
                    return true;

                case "og:audio:type":
                    if (string.IsNullOrEmpty(Type))
                    {
                        Type = content;
                    }
                    return true; 
            }

            child = null;
            return false;
        }
    }
}