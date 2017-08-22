using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class VideoOtherTest : GraphObjectTestBase
    {
        public VideoOtherTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# video: http://ogp.me/ns/video#'>
  <meta property='fb:app_id' content='302184056577324' /> 
  <meta property='og:type'   content='video.other' /> 
  <meta property='og:url'    content='Put your own URL to the object here' /> 
  <meta property='og:title'  content='Sample Video' /> 
  <meta property='og:image'  content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /> </head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "video.other",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Video",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    VideoOther = new VideoOther
                    {
                    }
                });
    }
}