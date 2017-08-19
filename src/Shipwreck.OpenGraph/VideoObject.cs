namespace Shipwreck.OpenGraph
{
    public abstract partial class VideoObject : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoObject" /> class.
        /// </summary>
        internal VideoObject()
            : this("video")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoObject" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal VideoObject(string path)
            : base(path)
        {
        }
    }
}