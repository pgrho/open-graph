namespace Shipwreck.OpenGraph
{
    internal static class GraphObjectExtensions
    {
        internal static void AddMetadataOrSetUrl(this GraphObject obj, bool setUrl, string property, string content)
        {
            if (setUrl)
            {
                if (obj.Url == null)
                {
                    obj.Url = content;
                }
            }
            else
            {
                obj.TryAddMetadata(property, content, out var c);
            }
        }
    }
}