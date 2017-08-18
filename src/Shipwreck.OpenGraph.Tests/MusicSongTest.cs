﻿using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class MusicSongTest
    {
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
    }
}