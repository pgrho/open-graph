using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class ProductTest : GraphObjectTestBase
    {
        public ProductTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# product: http://ogp.me/ns/product#'>
  <meta property='fb:app_id' content='302184056577324' />
  <meta property='og:type'   content='product' />
  <meta property='og:url'    content='Put your own URL to the object here' />
  <meta property='og:title'  content='Sample Product' />
  <meta property='og:image'  content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /></head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "product",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Product",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    Product = new Product
                    {
                    }
                });

        [Fact]
        public void ReferenceSampleTest_ProductItem()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# product: http://ogp.me/ns/product#'>
  <meta property='fb:app_id'                content='302184056577324' />
  <meta property='og:type'                  content='product.item' />
  <meta property='og:url'                   content='Put your own URL to the object here' />
  <meta property='og:title'                 content='Sample Item' />
  <meta property='og:image'                 content='https://fbstatic-a.akamaihd.net/images/devsite/attachment_blank.png' />
  <meta property='product:retailer_item_id' content='Sample Retailer Product Item ID' />
  <meta property='product:price:amount'     content='12345.67' />
  <meta property='product:price:currency'   content='Sample Price: ' />
  <meta property='product:availability'     content='Sample Availability' />
  <meta property='product:condition'        content='Sample Condition' /> </head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "product.item",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Item",
                    Image = new GraphImage()
                    {
                        Url = "https://fbstatic-a.akamaihd.net/images/devsite/attachment_blank.png"
                    },
                    Product = new Product
                    {
                        RetailerItemId = "Sample Retailer Product Item ID",
                        Price = new Currency()
                        {
                            Amount = 12345.67f,
                            Units = "Sample Price: "
                        },
                        Availability = "Sample Availability",
                        Condition = "Sample Condition"
                    }
                });
    }
}