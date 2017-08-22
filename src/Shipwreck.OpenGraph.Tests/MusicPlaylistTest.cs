using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class MusicPlaylistTest : GraphObjectTestBase
    {
        public MusicPlaylistTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# music: http://ogp.me/ns/music#'>
  <meta property='fb:app_id' content='302184056577324' />
  <meta property='og:type'   content='music.playlist' />
  <meta property='og:url'    content='Put your own URL to the object here' />
  <meta property='og:title'  content='Sample Music Playlist' />
  <meta property='og:image'  content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /></head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "music.playlist",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Music Playlist",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    MusicPlaylist = new MusicPlaylist
                    {
                    }
                });

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