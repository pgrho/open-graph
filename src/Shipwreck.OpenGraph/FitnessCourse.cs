namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents the user's activity contributing to a particular run, walk, or bike course.
    /// </summary>
    public sealed partial class FitnessCourse : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FitnessCourse" /> class.
        /// </summary>
        public FitnessCourse()
            : this(new PropertyPath(NamespaceCollection.Fitness))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FitnessCourse" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal FitnessCourse(PropertyPath path)
            : base(path)
        {
        }
    }
}