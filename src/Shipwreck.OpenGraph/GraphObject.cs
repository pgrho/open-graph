namespace Shipwreck.OpenGraph
{
    public abstract class GraphObject
    {
        internal abstract bool TryAddMetadata(string property, string content, out GraphObject child);
    }
}