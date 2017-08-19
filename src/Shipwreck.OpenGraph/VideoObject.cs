namespace Shipwreck.OpenGraph
{
    public abstract partial class VideoObject : GraphObject
    {
        public VideoObject()
            : this("video")
        {
        }

        internal VideoObject(string path)
            : base(path)
        {
        }

        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "actor", out matched))
            {
                return new Actor(Path + ":actor");
            }
            else if (property.StartsWithChildPath(Path, "director", out matched))
            {
                return new Profile(Path + ":director");
            }
            else if (property.StartsWithChildPath(Path, "writer", out matched))
            {
                return new Profile(Path + ":writer");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
}