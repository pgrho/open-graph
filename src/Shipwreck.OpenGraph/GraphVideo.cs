namespace Shipwreck.OpenGraph
{
    public sealed partial class GraphVideo : GraphObject
    {
        public GraphVideo()
            : this("og")
        {
        }

        internal GraphVideo(string path)
            : base(path)
        {
        }
    }
}