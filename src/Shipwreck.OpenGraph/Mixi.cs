namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Provides third party OGP extensions by <see href="http://mixi.co.jp"/>
    /// </summary>
    public static class Mixi
    {
        /// <summary>
        /// Defined Namespace URI for mixi OGP extensions.
        /// </summary>
        public const string Namespace = "http://mixi-platform.com/ns#";

        /// <summary>
        /// Gets the property path for <c>mixi:title</c>.
        /// </summary>
        public static PropertyPath Title => new PropertyPath(Namespace, "title");

        /// <summary>
        /// Gets the property path for <c>mixi:description</c>.
        /// </summary>
        public static PropertyPath Description => new PropertyPath(Namespace, "description");

        /// <summary>
        /// Gets the property path for <c>mixi:content-rating</c>.
        /// </summary>
        /// <remarks>
        /// <c>1</c> if the content is X-rated.
        /// </remarks>
        public static PropertyPath ContentRating => new PropertyPath(Namespace, "content-rating");
    }
}