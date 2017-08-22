using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class BusinessTest : GraphObjectTestBase
    {
        public BusinessTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html><head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# business: http://ogp.me/ns/business#'>
 <meta property='fb:app_id'                            content='302184056577324' />
 <meta property='og:type'                              content='business.business' />
 <meta property='og:url'                               content='Put your own URL to the object here' />
 <meta property='og:title'                             content='Sample Business' />
 <meta property='og:image'                             content='https://fbstatic-a.akamaihd.net/images/devsite/attachment_blank.png' />
 <meta property='business:contact_data:street_address' content='Sample Contact data: Street Address' />
 <meta property='business:contact_data:locality'       content='Sample Contact data: Locality' />
 <meta property='business:contact_data:postal_code'    content='Sample Contact data: Postal Code' />
 <meta property='business:contact_data:country_name'   content='Sample Contact data: Country Name' />
 <meta property='place:location:latitude'              content='123.45' />
 <meta property='place:location:longitude'             content='67.89' /></head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "business.business",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Business",
                    Image = new GraphImage
                    {
                        Url = "https://fbstatic-a.akamaihd.net/images/devsite/attachment_blank.png"
                    },
                    Business = new Business()
                    {
                        ContactData = new ContactData()
                        {
                            StreetAddress = "Sample Contact data: Street Address",
                            Locality = "Sample Contact data: Locality",
                            PostalCode = "Sample Contact data: Postal Code",
                            CountryName = "Sample Contact data: Country Name",
                        }
                    },
                    Location = new GeoPoint()
                    {
                        Latitude = 123.45f,
                        Longitude = 67.89f
                    }
                });
    }
}