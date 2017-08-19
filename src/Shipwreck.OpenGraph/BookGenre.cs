namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a genre of a book.
    /// </summary>
    public sealed partial class BookGenre : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookGenre" /> class.
        /// </summary>
        public BookGenre()
            : this("books")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BookGenre" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal BookGenre(string path)
            : base(path)
        {
        }
    }
}