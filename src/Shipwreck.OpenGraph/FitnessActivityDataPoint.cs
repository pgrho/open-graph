namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a data point of the fitness.
    /// </summary>
    public sealed partial class FitnessActivityDataPoint : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FitnessActivityDataPoint" /> class.
        /// </summary>
        public FitnessActivityDataPoint()
            : this(new PropertyPath(NamespaceCollection.Fitness, "metrics"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FitnessActivityDataPoint" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal FitnessActivityDataPoint(PropertyPath path)
            : base(path)
        {
        }
    }
}