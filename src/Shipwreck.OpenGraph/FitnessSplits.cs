namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents splits point of the fitness.
    /// </summary>
    public sealed partial class FitnessSplits : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FitnessSplits" /> class.
        /// </summary>
        public FitnessSplits()
            : this(new PropertyPath(NamespaceCollection.Fitness, "splits"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FitnessSplits" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal FitnessSplits(PropertyPath path)
            : base(path)
        {
        }
    }
}