namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a range of date and time that can attached to other <see cref="GraphObject"/>.
    /// </summary>
    public sealed partial class DateTimeRange : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeRange" /> class.
        /// </summary>
        public DateTimeRange()
            : this(new PropertyPath(NamespaceCollection.OpenGraph))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeRange" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal DateTimeRange(PropertyPath path)
            : base(path)
        {
        }
    }
}