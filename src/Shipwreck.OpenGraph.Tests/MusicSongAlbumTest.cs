using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class MusicSongAlbumTest
    {
        [Fact]
        public void DiscTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.song' />
<meta property='music:album:disc' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicSong);
            Assert.Equal(new int?[] { 55301 }, target.MusicSong.Albums.Select(a => a.Disc));
        }

        [Fact]
        public void TrackTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.song' />
<meta property='music:album:track' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicSong);
            Assert.Equal(new int?[] { 55301 }, target.MusicSong.Albums.Select(a => a.Track));
        }
    }
}