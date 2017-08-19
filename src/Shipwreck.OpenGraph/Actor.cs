using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed class Actor : Profile
    {
        public Actor()
        {
        }

        internal Actor(string path)
            : base(path)
        {
        }

        [DefaultValue(null)]
        public string Role
        {
            get => GetLocalProperty("role");
            set => SetLocalProperty("role", value);
        }
    }
}