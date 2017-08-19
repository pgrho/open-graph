using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed partial class Actor : Profile
    {
        public Actor()
        {
        }

        internal Actor(string path)
            : base(path)
        {
        }
    }
}