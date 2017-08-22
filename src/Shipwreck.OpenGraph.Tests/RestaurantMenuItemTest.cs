using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class RestaurantMenuItemTest : GraphObjectTestBase
    {
        public RestaurantMenuItemTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# restaurant: http://ogp.me/ns/restaurant#'>
  <meta property='fb:app_id'          content='302184056577324' />
  <meta property='og:type'            content='restaurant.menu_item' />
  <meta property='og:url'             content='Put your own URL to the object here' />
  <meta property='og:title'           content='Sample Menu Item' />
  <meta property='og:image'           content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' />
  <meta property='restaurant:section' content='Sample Section' /> </head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "restaurant.menu_item",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Menu Item",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    RestaurantMenuItem = new RestaurantMenuItem
                    {
                        Section = new RestaurantMenuSection()
                        {
                            Url = "Sample Section"
                        }
                    }
                });
    }
}