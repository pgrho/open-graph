using System.ComponentModel;
using System.Linq;

namespace Shipwreck.OpenGraph
{
    public partial class MusicRadioStation : GraphObject
    {
        public MusicRadioStation()
            : this("music")
        {
        }

        internal MusicRadioStation(string path)
            : base(path)
        {
        }

        [DefaultValue(null)]
        public Profile Creator
        {
            get => new GraphObjectChildCollection<Profile>(this, "creator").FirstOrDefault();
        }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(Path))
            {
                child = null;
                return false;
            }

            if (property.StartsWithChildPath(Path, "creator", out var matched))
            {
                child = new Profile(Path + ":creator");
                Children.Add(child);
                child.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}