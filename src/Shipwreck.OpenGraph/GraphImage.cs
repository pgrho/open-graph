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
            else if (property.MachesChildPath(Path, "width"))
            {
                if (Width == 0 && int.TryParse(content, out int i))
                {
                    Width = i;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "height"))
            {
                if (Height == 0 && int.TryParse(content, out int i))
                {
                    Height = i;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "alt"))
            {
                if (Alt == null)
                {
                    Alt = content;
                }

                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}