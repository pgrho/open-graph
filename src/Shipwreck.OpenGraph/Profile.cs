namespace Shipwreck.OpenGraph
{
    public partial class Profile : GraphObject
    {
        public Profile()
            : this("profile")
        {
        }

        internal Profile(string path)
            : base(path)
        {
        }
    }
}