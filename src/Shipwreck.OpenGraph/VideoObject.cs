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
    }
}