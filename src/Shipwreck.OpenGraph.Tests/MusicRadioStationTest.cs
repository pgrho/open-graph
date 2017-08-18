using Xunit;

namespace Shipwreck.OpenGraph
{
    public class MusicRadioStationTest
    {
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