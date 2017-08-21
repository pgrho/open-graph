namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents a book or publication.
    /// </summary>
    public sealed partial class Book : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Book" /> class.
        /// </summary>
        public Book()
            : this(new PropertyPath(NamespaceCollection.Book))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal Book(PropertyPath path)
            : base(path)
        {
        }
    }
}