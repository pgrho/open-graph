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
            if (!property.MachesPath(Path))
            {
                child = null;
                return false;
            }
            if (property.StartsWithChildPath(Path, "series", out var matched))
            {
                if (Series == null)
                {
                    Series = new VideoTVShow(Path + ":series");
                }
                child = Series.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}