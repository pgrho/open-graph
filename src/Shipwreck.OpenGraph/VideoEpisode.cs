using System.ComponentModel;
using System.Linq;

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
        public VideoTVShow Series
        {
            get => new GraphObjectChildCollection<VideoTVShow>(this, "series").FirstOrDefault();
        }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(Path))
            {
                child = null;
                return false;
            }
            if (property.StartsWithChildPath(Path, "series", out var matched))
            {
                child = new VideoTVShow(Path + ":series");
                Children.Add(child);
                child.AddMetadataOrSetUrl(matched, property, content);
                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}