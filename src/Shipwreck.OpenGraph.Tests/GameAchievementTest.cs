using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class GameAchievementTest : GraphObjectTestBase
    {
        public GameAchievementTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html>  <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# game: http://ogp.me/ns/game#'>
  <meta property='fb:app_id'   content='302184056577324' /> 
  <meta property='og:type'     content='game.achievement' /> 
  <meta property='og:url'      content='Put your own URL to the object here' /> 
  <meta property='og:title'    content='Sample Game Achievement' /> 
  <meta property='og:image'    content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /> 
  <meta property='game:points' content='55301' /> </head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "game.achievement",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Game Achievement",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    GameAchievement = new GameAchievement
                    {
                        Points = 55301
                    }
                });
    }
}