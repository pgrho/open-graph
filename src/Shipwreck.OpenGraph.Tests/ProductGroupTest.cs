using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class ProductGroupTest : GraphObjectTestBase
    {
        public ProductGroupTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# product: http://ogp.me/ns/product#'>
  <meta property='fb:app_id' content='302184056577324' />
  <meta property='og:type'   content='product.group' />
  <meta property='og:url'    content='Put your own URL to the object here' />
  <meta property='og:title'  content='Sample Group' />
  <meta property='og:image'  content='https://fbstatic-a.akamaihd.net/images/devsite/attachment_blank.png' /> </head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "product.group",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Group",
                    Image = new GraphImage()
                    {
                        Url = "https://fbstatic-a.akamaihd.net/images/devsite/attachment_blank.png"
                    },
                    ProductGroup = new ProductGroup
                    {
                    }
                });
    }
}