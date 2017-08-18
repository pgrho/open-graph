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
        public string FirstName { get; set; }

        [DefaultValue(null)]
        public string LastName { get; set; }

        [DefaultValue(null)]
        public string UserName { get; set; }

        [DefaultValue(null)]
        public string Gender { get; set; }

        internal override bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            child = null;
            if (!property.MachesPath(Path))
            {
                return false;
            }
            if (property.MachesChildPath(Path, "first_name"))
            {
                if (FirstName == null)
                {
                    FirstName = content;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "last_name"))
            {
                if (LastName == null)
                {
                    LastName = content;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "username"))
            {
                if (UserName == null)
                {
                    UserName = content;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "gender"))
            {
                if (Gender == null)
                {
                    Gender = content;
                }

                return true;
            }

            return base.TryAddMetadata(property, content, out child);
        }
    }
}