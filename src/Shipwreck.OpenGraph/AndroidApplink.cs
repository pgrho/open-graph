namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents an Android application attached to the graph.
    /// </summary>
    public sealed partial class AndroidApplink : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidApplink" /> class.
        /// </summary>
        public AndroidApplink()
            : this(new PropertyName(NamespaceCollection.Applink, "android"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidApplink" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal AndroidApplink(PropertyName path)
            : base(path)
        {
        }
    }
}