using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public partial class Profile : GraphObject
    {
        internal readonly string _Path;

        public Profile()
        {
            _Path = "profile";
        }

        internal Profile(string path)
        {
            _Path = path;
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
            if (!property.MachesPath(_Path))
            {
                return false;
            }
            if (property.MachesChildPath(_Path, "first_name"))
            {
                if (FirstName == null)
                {
                    FirstName = content;
                }

                return true;
            }
            else if (property.MachesChildPath(_Path, "last_name"))
            {
                if (LastName == null)
                {
                    LastName = content;
                }

                return true;
            }
            else if (property.MachesChildPath(_Path, "username"))
            {
                if (UserName == null)
                {
                    UserName = content;
                }

                return true;
            }
            else if (property.MachesChildPath(_Path, "gender"))
            {
                if (Gender == null)
                {
                    Gender = content;
                }

                return true;
            }

            return false;
        }
    }
}