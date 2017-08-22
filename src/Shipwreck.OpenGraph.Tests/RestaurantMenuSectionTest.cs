using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class RestaurantMenuSectionTest : GraphObjectTestBase
    {
        public RestaurantMenuSectionTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# restaurant: http://ogp.me/ns/restaurant#'>
  <meta property='fb:app_id'       content='302184056577324' />
  <meta property='og:type'         content='restaurant.menu_section' />
  <meta property='og:url'          content='Put your own URL to the object here' />
  <meta property='og:title'        content='Sample Menu Section' />
  <meta property='og:image'        content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' />
  <meta property='restaurant:menu' content='Sample Menu' /> </head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "restaurant.menu_section",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Menu Section",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    RestaurantMenuSection = new RestaurantMenuSection
                    {
                        Menu = new RestaurantMenu()
                        {
                            Url = "Sample Menu"
                        }
                    }
                });
    }
}