using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed partial class VideoEpisode : VideoObject
    {
        public VideoEpisode()
        {
        }

        internal VideoEpisode(string path)
            : base(path)
        {
        }

        [DefaultValue(null)]
        public VideoTVShow Series { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(_Path))
            {
                child = null;
                return false;
            }
            if (property.StartsWithChildPath(_Path, "series"))
            {
                if (Series == null)
                {
                    Series = new VideoTVShow(_Path + ":series");
                }
                Series.TryAddMetadata(property, content, out child);
                child = child ?? Series;
                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}