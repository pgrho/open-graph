using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class GraphAudioTest
    {
        #region Url

        [Fact]
        public void UrlTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:audio:url' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Audios?.Select(i => i.Url));
        }

        [Fact]
        public void UrlsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:audio:url' content='The Rock' />
<meta property='og:audio:url' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.Audios?.Select(i => i.Url));
        }

        #endregion Url

        #region SecureUrl

        [Fact]
        public void SecureUrlTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:audio:secure_url' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Audios?.Select(i => i.SecureUrl));
        }

        [Fact]
        public void SecureUrlsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:audio' content='img' />
<meta property='og:audio:secure_url' content='The Rock' />
<meta property='og:audio:secure_url' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Audios?.Select(i => i.SecureUrl));
        }

        #endregion SecureUrl

        #region Type

        [Fact]
        public void TypeTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:audio:type' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Audios?.Select(i => i.Type));
        }

        [Fact]
        public void TypesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:audio' content='img' />
<meta property='og:audio:type' content='The Rock' />
<meta property='og:audio:type' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Audios?.Select(i => i.Type));
        }

        #endregion Type
    }
}