using System;
using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class MusicAlbumTest
    {
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
    }
}