using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class MusicSongTest : GraphObjectTestBase
    {
        public MusicSongTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# music: http://ogp.me/ns/music#'>
  <meta property='fb:app_id' content='302184056577324' /> 
  <meta property='og:type'   content='music.song' /> 
  <meta property='og:url'    content='Put your own URL to the object here' /> 
  <meta property='og:title'  content='Sample Song' /> 
  <meta property='og:image'  content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /></head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "music.song",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Song",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    MusicSong = new MusicSong()
                });

        [Fact]
        public void DurationTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.song' />
<meta property='music:duration' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicSong);
            Assert.Equal(55301, target.MusicSong.Duration);
        }

        #region Album

        [Fact]
        public void AlbumTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.song' />
<meta property='music:album' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicSong);
            Assert.Equal(new[] { "55301" }, target.MusicSong.Albums.Select(a => a.Url));
        }

        [Fact]
        public void AlbumsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.song' />
<meta property='music:album' content='55301' />
<meta property='music:album' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicSong);
            Assert.Equal(new[] { "55301", "100puri" }, target.MusicSong.Albums.Select(a => a.Url));
        }

        #endregion Album

        #region Musician

        [Fact]
        public void MusicianTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.song' />
<meta property='music:musician' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicSong);
            Assert.Equal(new[] { "55301" }, target.MusicSong.Musicians.Select(a => a.Url));
        }

        [Fact]
        public void MusiciansTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.song' />
<meta property='music:musician' content='55301' />
<meta property='music:musician' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicSong);
            Assert.Equal(new[] { "55301", "100puri" }, target.MusicSong.Musicians.Select(a => a.Url));
        }

        #endregion Musician

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