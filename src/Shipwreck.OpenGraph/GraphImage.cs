namespace Shipwreck.OpenGraph
{
    public sealed partial class GraphImage : GraphObject
    {
        public GraphImage()
            : this("og")
        {
        }

        internal GraphImage(string path)
            : base(path)
        {
        }
    }
}