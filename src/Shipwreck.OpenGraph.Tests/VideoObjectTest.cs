using System;
using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class VideoObjectTest
    {
        #region Actor

        [Fact]
        public void ActorTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:actor' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal(new[] { "55301" }, target.VideoMovie.Actors.Select(a => a.Url));
        }

        [Fact]
        public void ActorsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:actor' content='55301' />
<meta property='video:actor' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal(new[] { "55301", "100puri" }, target.VideoMovie.Actors.Select(a => a.Url));
        }

        #endregion Actor

        #region Director

        [Fact]
        public void DirectorTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:director' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal(new[] { "55301" }, target.VideoMovie.Directors.Select(a => a.Url));
        }

        [Fact]
        public void DirectorsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:director' content='55301' />
<meta property='video:director' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal(new[] { "55301", "100puri" }, target.VideoMovie.Directors.Select(a => a.Url));
        }

        #endregion Director

        #region Writer

        [Fact]
        public void WriterTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:writer' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal(new[] { "55301" }, target.VideoMovie.Writers.Select(a => a.Url));
        }

        [Fact]
        public void WritersTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:writer' content='55301' />
<meta property='video:writer' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal(new[] { "55301", "100puri" }, target.VideoMovie.Writers.Select(a => a.Url));
        }

        #endregion Writer

        [Fact]
        public void DurationTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:duration' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal(55301, target.VideoMovie.Duration);
        }

        [Fact]
        public void ReleaseDateTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:release_date' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal(new DateTime(2003, 4, 5), target.VideoMovie.ReleaseDate);
        }

        #region Tag

        [Fact]
        public void TagTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:tag' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal(new[] { "55301" }, target.VideoMovie.Tags);
        }

        [Fact]
        public void TagsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:tag' content='55301' />
<meta property='video:tag' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal(new[] { "55301", "100puri" }, target.VideoMovie.Tags);
        }

        #endregion Tag
    }
}