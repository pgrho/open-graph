using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed partial class GraphAudio : GraphObject
    {
        public GraphAudio()
            : this("og")
        {
        }

        internal GraphAudio(string path)
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
    }
}