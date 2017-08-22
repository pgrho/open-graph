using System;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class MusicAlbumTest : GraphObjectTestBase
    {
        public MusicAlbumTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# music: http://ogp.me/ns/music#'>
  <meta property='fb:app_id' content='302184056577324' /> 
  <meta property='og:type'   content='music.album' /> 
  <meta property='og:url'    content='Put your own URL to the object here' /> 
  <meta property='og:title'  content='Sample Album' /> 
  <meta property='og:image'  content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /></head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "music.album",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Album",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    MusicAlbum = new MusicAlbum()
                });

        #region Song

        [Fact]
        public void SongTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.album' />
<meta property='music:song' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicAlbum);
            Assert.Equal(new[] { "55301" }, target.MusicAlbum.Songs.Select(a => a.Url));
        }

        [Fact]
        public void SongsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.album' />
<meta property='music:song' content='55301' />
<meta property='music:song' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicAlbum);
            Assert.Equal(new[] { "55301", "100puri" }, target.MusicAlbum.Songs.Select(a => a.Url));
        }

        #endregion Song

        #region Musician

        [Fact]
        public void MusicianTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.album' />
<meta property='music:musician' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicAlbum);
            Assert.Equal(new[] { "55301" }, target.MusicAlbum.Musicians.Select(a => a.Url));
        }

        [Fact]
        public void MusiciansTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.album' />
<meta property='music:musician' content='55301' />
<meta property='music:musician' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicAlbum);
            Assert.Equal(new[] { "55301", "100puri" }, target.MusicAlbum.Musicians.Select(a => a.Url));
        }

        #endregion Musician

        [Fact]
        public void ReleaseDateTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.album' />
<meta property='music:release_date' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicAlbum);
            Assert.Equal(new DateTime(2003, 4, 5), target.MusicAlbum.ReleaseDate);
        }

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