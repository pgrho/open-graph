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

        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "creator", out matched))
            {
                return new Profile(Path + ":creator");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
}