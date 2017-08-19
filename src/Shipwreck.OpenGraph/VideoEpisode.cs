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