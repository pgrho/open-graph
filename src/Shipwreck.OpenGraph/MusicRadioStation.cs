using System.ComponentModel;

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
        public Profile Creator { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(Path))
            {
                child = null;
                return false;
            }

            if (property.StartsWithChildPath(Path, "creator"))
            {
                if (Creator == null)
                {
                    Creator = new Profile(Path + ":creator");
                }
                Creator.TryAddMetadata(property, content, out child);
                child = child ?? Creator;
                return true;
            }

            child = null;
            return false;
        }
    }
}