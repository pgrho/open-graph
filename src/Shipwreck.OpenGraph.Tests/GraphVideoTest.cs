using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class GraphVideoTest
    {
        #region Url

        [Fact]
        public void UrlTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video:url' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Videos?.Select(i => i.Url));
            Assert.False(target.ShouldSerializeVideo());
            Assert.True(target.ShouldSerializeVideos());
        }

        [Fact]
        public void UrlsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video:url' content='The Rock' />
<meta property='og:video:url' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.Videos?.Select(i => i.Url));
        }

        #endregion Url

        #region SecureUrl

        [Fact]
        public void SecureUrlTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video:secure_url' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Videos?.Select(i => i.SecureUrl));
        }

        [Fact]
        public void SecureUrlsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video' content='img' />
<meta property='og:video:secure_url' content='The Rock' />
<meta property='og:video:secure_url' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Videos?.Select(i => i.SecureUrl));
        }

        #endregion SecureUrl

        #region Type

        [Fact]
        public void TypeTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video:type' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Videos?.Select(i => i.Type));
        }

        [Fact]
        public void TypesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video' content='img' />
<meta property='og:video:type' content='The Rock' />
<meta property='og:video:type' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Videos?.Select(i => i.Type));
        }

        #endregion Type

        #region Width

        [Fact]
        public void WidthTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video:width' content='1' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new int?[] { 1 }, target.Videos?.Select(i => i.Width));
        }

        [Fact]
        public void WidthsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video' content='img' />
<meta property='og:video:width' content='2' />
<meta property='og:video:width' content='3' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new int?[] { 2 }, target.Videos?.Select(i => i.Width));
        }

        #endregion Width

        #region Height

        [Fact]
        public void HeightTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video:height' content='1' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new int?[] { 1 }, target.Videos?.Select(i => i.Height));
        }

        [Fact]
        public void HeightsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video' content='img' />
<meta property='og:video:height' content='2' />
<meta property='og:video:height' content='3' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new int?[] { 2 }, target.Videos?.Select(i => i.Height));
        }

        #endregion Height

        #region Alt

        [Fact]
        public void AltTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video:alt' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Videos?.Select(i => i.Alt));
        }

        [Fact]
        public void AltsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:video' content='img' />
<meta property='og:video:alt' content='The Rock' />
<meta property='og:video:alt' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Videos?.Select(i => i.Alt));
        }

        #endregion Alt
    }
}