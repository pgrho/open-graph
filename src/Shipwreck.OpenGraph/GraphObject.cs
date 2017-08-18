namespace Shipwreck.OpenGraph
{
    public abstract class GraphObject
    {
        internal GraphObject(string path)
        {
            Path = path;
        }

        internal string Path { get; }

        internal abstract bool TryAddMetadata(string property, string content, out GraphObject child);
    }
}