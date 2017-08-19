namespace Shipwreck.OpenGraph
{
    public sealed partial class Book : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Book" /> class.
        /// </summary>
        public Book()
            : this("book")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal Book(string path)
            : base(path)
        {
        }
    }
}