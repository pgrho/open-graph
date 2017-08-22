using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class MusicRadioStationTest : GraphObjectTestBase
    {
        public MusicRadioStationTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# music: http://ogp.me/ns/music#'>
  <meta property='fb:app_id' content='302184056577324' /> 
  <meta property='og:type'   content='music.radio_station' /> 
  <meta property='og:url'    content='Put your own URL to the object here' /> 
  <meta property='og:title'  content='Sample Radio Station' /> 
  <meta property='og:image'  content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /> </head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "music.radio_station",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Radio Station",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    MusicRadioStation = new MusicRadioStation
                    {
                    }
                });

        [Fact]
        public void CreatorTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.radio_station' />
<meta property='music:creator' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicRadioStation);
            Assert.Equal("55301", target.MusicRadioStation.Creator.Url);
        }
    }
}