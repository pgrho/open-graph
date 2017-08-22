namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a range of business hours of the day that can attached to other <see cref="GraphObject"/>.
    /// </summary>
    public sealed partial class BusinessHour : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessHour" /> class.
        /// </summary>
        public BusinessHour()
            : this(new PropertyPath(NamespaceCollection.Business, "hours"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessHour" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal BusinessHour(PropertyPath path)
            : base(path)
        {
        }
    }
}