namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a specific achievement in a game.
    /// </summary>
    public sealed partial class GameAchievement : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameAchievement" /> class.
        /// </summary>
        public GameAchievement()
            : this(new PropertyPath(NamespaceCollection.Game))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameAchievement" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal GameAchievement(PropertyPath path)
            : base(path)
        {
        }
    }
}