namespace Shipwreck.OpenGraph
{
    public sealed partial class GraphAudio : GraphObject
    {
        public GraphAudio()
            : this("og")
        {
        }

        internal GraphAudio(string path)
            : base(path)
        {
        }
    }
}