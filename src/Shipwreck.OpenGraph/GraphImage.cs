using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed partial class GraphImage : GraphObject
    {
        public GraphImage()
            : this("og")
        {
        }

        internal GraphImage(string path)
            : base(path)
        {
        }

        [DefaultValue(null)]
        public string SecureUrl
        {
            get => GetLocalProperty("secure_url");
            set => SetLocalProperty("secure_url", value);
        }

        [DefaultValue(null)]
        public string Type
        {
            get => GetLocalProperty("type");
            set => SetLocalProperty("type", value);
        }

        [DefaultValue(null)]
        public int? Width
        {
            get => GetLocalPropertyAsInt32("width");
            set => SetLocalProperty("width", value);
        }

        [DefaultValue(null)]
        public int? Height
        {
            get => GetLocalPropertyAsInt32("height");
            set => SetLocalProperty("height", value);
        }

        [DefaultValue(null)]
        public string Alt
        {
            get => GetLocalProperty("alt");
            set => SetLocalProperty("alt", value);
        }
    }
}