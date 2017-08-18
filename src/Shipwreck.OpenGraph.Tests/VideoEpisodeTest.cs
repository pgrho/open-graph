using Xunit;

namespace Shipwreck.OpenGraph
{
    public class VideoEpisodeTest
    {
        [Fact]
        public void SeriesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.episode' />
<meta property='video:series' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoEpisode);
            Assert.Equal("55301", target.VideoEpisode.Series.Url);
        }
    }
}