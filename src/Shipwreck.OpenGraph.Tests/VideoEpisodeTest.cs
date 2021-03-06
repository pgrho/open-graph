using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class VideoEpisodeTest : GraphObjectTestBase
    {
        public VideoEpisodeTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# video: http://ogp.me/ns/video#'>
  <meta property='fb:app_id' content='302184056577324' /> 
  <meta property='og:type'   content='video.episode' /> 
  <meta property='og:url'    content='Put your own URL to the object here' /> 
  <meta property='og:title'  content='Sample TV Episode' /> 
  <meta property='og:image'  content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /> </head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "video.episode",
                    Url = "Put your own URL to the object here",
                    Title = "Sample TV Episode",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    VideoEpisode = new VideoEpisode
                    {

                    }
                });

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