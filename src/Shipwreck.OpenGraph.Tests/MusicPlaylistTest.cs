using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class MusicPlaylistTest
    {
        #region Song

        [Fact]
        public void SongTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.playlist' />
<meta property='music:song' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicPlaylist);
            Assert.Equal(new[] { "55301" }, target.MusicPlaylist.Songs.Select(a => a.Url));
        }

        [Fact]
        public void SongsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.playlist' />
<meta property='music:song' content='55301' />
<meta property='music:song' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicPlaylist);
            Assert.Equal(new[] { "55301", "100puri" }, target.MusicPlaylist.Songs.Select(a => a.Url));
        }

        #endregion Song

        [Fact]
        public void CreatorTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.playlist' />
<meta property='music:creator' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicPlaylist);
            Assert.Equal("55301", target.MusicPlaylist.Creator.Url);
        }
    }
}