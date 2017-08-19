using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class MusicAlbumSongTest
    {
        [Fact]
        public void DiscTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.album' />
<meta property='music:song:disc' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicAlbum);
            Assert.Equal(new int?[] { 55301 }, target.MusicAlbum.Songs.Select(a => a.Disc));
        }

        [Fact]
        public void TrackTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.album' />
<meta property='music:song:track' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicAlbum);
            Assert.Equal(new int?[] { 55301 }, target.MusicAlbum.Songs.Select(a => a.Track));
        }
    }
}