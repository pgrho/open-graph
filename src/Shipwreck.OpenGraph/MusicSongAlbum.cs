using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public sealed class MusicSongAlbum : MusicAlbum
    {
        public MusicSongAlbum()
        {
        }

        internal MusicSongAlbum(string path)
            : base(path)
        {
        }

        [DefaultValue(null)]
        public int? Disc
        {
            get => GetLocalPropertyAsInt32("disc");
            set => SetLocalProperty("disc", value);
        }

        [DefaultValue(null)]
        public int? Track
        {
            get => GetLocalPropertyAsInt32("track");
            set => SetLocalProperty("track", value);
        }
    }
}