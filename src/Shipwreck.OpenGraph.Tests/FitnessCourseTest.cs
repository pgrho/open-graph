using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class FitnessCourseTest : GraphObjectTestBase
    {
        public FitnessCourseTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# fitness: http://ogp.me/ns/fitness#'>
  <meta property='fb:app_id' content='302184056577324' /> 
  <meta property='og:type'   content='fitness.course' /> 
  <meta property='og:url'    content='Put your own URL to the object here' /> 
  <meta property='og:title'  content='Sample Course' /> 
  <meta property='og:image'  content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /> </head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "fitness.course",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Course",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    FitnessCourse = new FitnessCourse
                    {
                    }
                });
    }
}