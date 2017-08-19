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

        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "series", out matched))
            {
                return new VideoTVShow(Path + ":series");
            }

            return base.CreateNewChild(property, out matched);
        }
    }
}