namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Provides a base type of video namespace object.
    /// </summary>
    public abstract partial class VideoObject : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoObject" /> class.
        /// </summary>
        internal VideoObject()
            : this(new PropertyPath(NamespaceCollection.Video))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoObject" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal VideoObject(PropertyPath path)
            : base(path)
        {
        }
    }
}