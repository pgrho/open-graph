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
        public string SecureUrl { get; set; }

        [DefaultValue(null)]
        public string Type { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            child = null;
            if (!property.MachesPath(Path))
            {
                return false;
            }
            if (property.MachesChildPath(Path, "type"))
            {
                if (Type == null)
                {
                    Type = content;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "secure_url"))
            {
                if (SecureUrl == null)
                {
                    SecureUrl = content;
                }

                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}