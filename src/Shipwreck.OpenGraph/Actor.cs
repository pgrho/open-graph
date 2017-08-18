using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed class Actor : Profile
    {
        public Actor()
        {
        }

        internal Actor(string path)
            : base(path)
        {
        }

        [DefaultValue(0)]
        public string Role { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(Path))
            {
                child = null;
                return false;
            }

            if (property.MachesChildPath(Path, "role"))
            {
                if (Role == null)
                {
                    Role = content;
                }

                child = null;
                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}