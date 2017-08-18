namespace Shipwreck.OpenGraph
{
    public struct GraphProperty
    {
        public GraphProperty(string property, string content)
        {
            Property = property;
            Content = content;
        }

        public string Property { get; set; }
        public string Content { get; set; }
    }
}