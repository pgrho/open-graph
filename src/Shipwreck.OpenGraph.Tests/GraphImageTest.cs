using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class GraphImageTest
    {
        #region Url

        [Fact]
        public void UrlTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image:url' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Images?.Select(i => i.Url));
        }

        [Fact]
        public void UrlsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image:url' content='The Rock' />
<meta property='og:image:url' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.Images?.Select(i => i.Url));
        }

        #endregion Url

        #region SecureUrl

        [Fact]
        public void SecureUrlTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image:secure_url' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Images?.Select(i => i.SecureUrl));
        }

        [Fact]
        public void SecureUrlsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image' content='img' />
<meta property='og:image:secure_url' content='The Rock' />
<meta property='og:image:secure_url' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Images?.Select(i => i.SecureUrl));
        }

        #endregion SecureUrl

        #region Type

        [Fact]
        public void TypeTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image:type' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Images?.Select(i => i.Type));
        }

        [Fact]
        public void TypesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image' content='img' />
<meta property='og:image:type' content='The Rock' />
<meta property='og:image:type' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Images?.Select(i => i.Type));
        }

        #endregion Type

        #region Width

        [Fact]
        public void WidthTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image:width' content='1' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new int? [] { 1 }, target.Images?.Select(i => i.Width));
        }

        [Fact]
        public void WidthsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image' content='img' />
<meta property='og:image:width' content='2' />
<meta property='og:image:width' content='3' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new int?[] { 2 }, target.Images?.Select(i => i.Width));
        }

        #endregion Width

        #region Height

        [Fact]
        public void HeightTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image:height' content='1' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new int?[] { 1 }, target.Images?.Select(i => i.Height));
        }

        [Fact]
        public void HeightsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image' content='img' />
<meta property='og:image:height' content='2' />
<meta property='og:image:height' content='3' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new int?[] { 2 }, target.Images?.Select(i => i.Height));
        }

        #endregion Height

        #region Alt

        [Fact]
        public void AltTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image:alt' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Images?.Select(i => i.Alt));
        }

        [Fact]
        public void AltsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image' content='img' />
<meta property='og:image:alt' content='The Rock' />
<meta property='og:image:alt' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Images?.Select(i => i.Alt));
        }

        #endregion Alt
    }
}