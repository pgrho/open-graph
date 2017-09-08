using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class HtmlAgilityPackTest : GraphObjectTestBase
    {
        public HtmlAgilityPackTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public Task BookTest()
            => TestUrl("https://raw.githubusercontent.com/niallkennedy/open-graph-protocol-examples/master/book-isbn10.html",
                new Graph()
                {
                    Title = "Steve Jobs",
                    SiteName = "Open Graph protocol examples",
                    Type = "book",
                    Locale = "en_US",
                    Url = "http://examples.opengraphprotocol.us/book-isbn10.html",

                    Image = new GraphImage
                    {
                        Url = "http://examples.opengraphprotocol.us/media/images/50.png",
                        SecureUrl = "https://d72cgtgi6hvvl.cloudfront.net/media/images/50.png",
                        Width = 50,
                        Height = 50,
                        Type = "image/png"
                    },

                    Book = new Book
                    {
                        ["release_date"] = "2011-10-24",
                        ISBN = "1451648537",
                        Tags = new[] { "Steve Jobs", "Apple", "Pixar" }
                    }
                });

        [Fact]
        public Task VideoMovieTest()
            => TestUrl("https://raw.githubusercontent.com/niallkennedy/open-graph-protocol-examples/77e4710fc3791a212c92739f52e32d9d48ccba30/video-movie.html",
                new Graph()
                {
                    Title = "Arrival of a Train at La Ciotat",
                    Description = "L'arrivée d'un train en gare de La Ciotat is an 1895 French short black-and-white silent documentary film directed and produced by Auguste and Louis Lumière. Its first public showing took place in January 1896.",
                    SiteName = "Open Graph protocol examples",
                    Type = "video.movie",
                    Locale = "en_US",
                    Url = "http://examples.opengraphprotocol.us/video-movie.html",

                    Image = new GraphImage
                    {
                        Url = "http://examples.opengraphprotocol.us/media/images/train.jpg",
                        SecureUrl = "https://d72cgtgi6hvvl.cloudfront.net/media/images/train.jpg",
                        Width = 500,
                        Height = 328,
                        Type = "image/jpeg"
                    },

                    Videos = new[]
                    {
                        new GraphVideo
                        {
                            Url ="http://fpdownload.adobe.com/strobe/FlashMediaPlayback.swf?src=http%3A%2F%2Fexamples.opengraphprotocol.us%2Fmedia%2Fvideo%2Ftrain.mp4",
                            SecureUrl = "https://fpdownload.adobe.com/strobe/FlashMediaPlayback.swf?src=https%3A%2F%2Fd72cgtgi6hvvl.cloudfront.net%2Fmedia%2Fvideo%2Ftrain.mp4",
                            Type ="application/x-shockwave-flash",
                            Width = 472,
                            Height = 296
                        },
                        new GraphVideo
                        {
                            Url ="http://examples.opengraphprotocol.us/media/video/train.mp4",
                            SecureUrl = "https://d72cgtgi6hvvl.cloudfront.net/media/video/train.mp4",
                            Type = "video/mp4",
                            Width = 472,
                            Height = 296
                        },
                        new GraphVideo
                        {
                            Url ="http://examples.opengraphprotocol.us/media/video/train.webm",
                            SecureUrl = "https://d72cgtgi6hvvl.cloudfront.net/media/video/train.webm",
                            Type ="video/webm",
                            Width = 480,
                            Height = 320
                        },
                    },

                    VideoMovie = new VideoMovie
                    {
                        ["release_date"] = "1895-12-28",
                        Director = new Profile
                        {
                            Url = "http://examples.opengraphprotocol.us/profile.html"
                        },
                        Duration = 50,
                        Tags = new[] { "La Ciotat", "train" }
                    }
                });

        [Theory]
        [InlineData("http://store.steampowered.com/app/648100/_/")]
        public Task NotImplementedTest(string url)
            => TestUrl(url, new Graph(), assertion: (e, a) =>
            {
                Assert.Equal(e.SiteName, a.SiteName);
            });

    }
}