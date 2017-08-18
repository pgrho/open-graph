using System;
using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public partial class MusicRadioStation : GraphObject
    {
        internal readonly string _Path;

        public MusicRadioStation()
        {
            _Path = "music";
        }

        internal MusicRadioStation(string path)
        {
            _Path = path;
        }

        [DefaultValue(null)]
        public Profile Creator { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(_Path))
            {
                child = null;
                return false;
            }

            if (property.StartsWithChildPath(_Path, "creator"))
            {
                if (Creator == null)
                {
                    Creator = new Profile(_Path + ":creator");
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