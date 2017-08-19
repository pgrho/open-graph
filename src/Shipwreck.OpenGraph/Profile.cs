namespace Shipwreck.OpenGraph
{
    public sealed partial class Profile : GraphObject
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