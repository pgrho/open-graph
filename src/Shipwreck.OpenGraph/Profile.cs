using System.ComponentModel;

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

        [DefaultValue(null)]
        public string FirstName
        {
            get => GetLocalProperty("first_name");
            set => SetLocalProperty("first_name", value);
        }

        [DefaultValue(null)]
        public string LastName
        {
            get => GetLocalProperty("last_name");
            set => SetLocalProperty("last_name", value);
        }

        [DefaultValue(null)]
        public string UserName
        {
            get => GetLocalProperty("username");
            set => SetLocalProperty("username", value);
        }

        [DefaultValue(null)]
        public string Gender
        {
            get => GetLocalProperty("gender");
            set => SetLocalProperty("gender", value);
        }
    }
}