namespace Shipwreck.OpenGraph
{
    public sealed partial class Book : GraphObject
    {
        public Book()
            : this("book")
        {
        }

        internal Book(string path)
            : base(path)
        {
        }
    }
}