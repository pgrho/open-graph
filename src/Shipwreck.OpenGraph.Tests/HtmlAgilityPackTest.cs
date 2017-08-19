using System.Linq;
using System.Net.Http;
using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class HtmlAgilityPackTest
    {
        private void Run(string url, Graph expected)
        {
            // TODO: Network failure must be treated as inconclusive
            Graph actual;
            using (var hc = new HttpClient())
            {
                var html = hc.GetStringAsync(url).GetAwaiter().GetResult();
                var hd = new HtmlAgilityPack.HtmlDocument();
                hd.LoadHtml(html);

                actual = Graph.FromXPathNavigable(hd);
            }

            AssertObject(expected, actual);
        }

        private void AssertObject(GraphObject expected, GraphObject actual)
        {
            Assert.Equal(expected.GetType(), actual.GetType());
            Assert.Equal(expected.Path, actual.Path);

            foreach (var pn in expected.LocalProperties.Concat(actual.LocalProperties).Select(p => p.Property).Distinct())
            {
                var evs = expected.LocalProperties.Where(p => p.Property == pn).ToArray();

                if (!evs.Any())
                {
                    _Output.WriteLine($"Unexpected property: {pn} at {actual.Path}");
                    continue;
                }

                Assert.Equal(evs, actual.LocalProperties.Where(p => p.Property == pn));
            }

            foreach (var pn in expected.Children.Concat(actual.Children).Select(p => p.Path).Distinct())
            {
                var evs = expected.Children.Where(p => p.Path == pn).ToArray();

                if (!evs.Any())
                {
                    _Output.WriteLine($"Unexpected child: {pn}");
                    continue;
                }

                var avs = actual.Children.Where(p => p.Path == pn).ToArray();

                Assert.Equal(evs.Length, avs.Length);

                for (int i = 0; i < evs.Length; i++)
                {
                    AssertObject(evs[i], avs[i]);
                }
            }

            var to = (expected as Graph)?.TypeObject;
            var ato = (actual as Graph)?.TypeObject;
            if (to != null)
            {
                AssertObject(to, ato);
            }
            else
            {
                Assert.Null(ato);
            }
        }

        private readonly ITestOutputHelper _Output;

        public HtmlAgilityPackTest(ITestOutputHelper output)
        {
            _Output = output;
        }

        [Fact]
        public void BookTest()
            => Run("https://raw.githubusercontent.com/niallkennedy/open-graph-protocol-examples/master/book-isbn10.html",
                new Graph()
                {
                    Title = "Steve Jobs",
                    SiteName = "Open Graph protocol examples",
                    Type = "book",
                    Locale = "en_US",
                    Url = "http://examples.opengraphprotocol.us/book-isbn10.html",

                    Image = new GraphImage("og:image")
                    {
                        Url = "http://examples.opengraphprotocol.us/media/images/50.png",
                        SecureUrl = "https://d72cgtgi6hvvl.cloudfront.net/media/images/50.png",
                        Width = 50,
                        Height = 50,
                        Type = "image/png"
                    },

                    Book = new Book()
                    {
                        ["release_date"] = "2011-10-24",
                        ISBN = "1451648537",
                        Tags = new[] { "Steve Jobs", "Apple", "Pixar" }
                    }
                });

        [Fact]
        public void VideoMovieTest()
            => Run("https://raw.githubusercontent.com/niallkennedy/open-graph-protocol-examples/77e4710fc3791a212c92739f52e32d9d48ccba30/video-movie.html",
                new Graph()
                {
                    Title = "Arrival of a Train at La Ciotat",
                    Description = "L'arrivée d'un train en gare de La Ciotat is an 1895 French short black-and-white silent documentary film directed and produced by Auguste and Louis Lumière. Its first public showing took place in January 1896.",
                    SiteName = "Open Graph protocol examples",
                    Type = "video.movie",
                    Locale = "en_US",
                    Url = "http://examples.opengraphprotocol.us/video-movie.html",

                    Image = new GraphImage("og:image")
                    {
                        Url = "http://examples.opengraphprotocol.us/media/images/train.jpg",
                        SecureUrl = "https://d72cgtgi6hvvl.cloudfront.net/media/images/train.jpg",
                        Width = 500,
                        Height = 328,
                        Type = "image/jpeg"
                    },

                    Videos = new[]
                    {
                        new GraphVideo("og:video")
                        {
                            Url ="http://fpdownload.adobe.com/strobe/FlashMediaPlayback.swf?src=http%3A%2F%2Fexamples.opengraphprotocol.us%2Fmedia%2Fvideo%2Ftrain.mp4",
                            SecureUrl = "https://fpdownload.adobe.com/strobe/FlashMediaPlayback.swf?src=https%3A%2F%2Fd72cgtgi6hvvl.cloudfront.net%2Fmedia%2Fvideo%2Ftrain.mp4",
                            Type ="application/x-shockwave-flash",
                            Width = 472,
                            Height = 296
                        },
                        new GraphVideo("og:video")
                        {
                            Url ="http://examples.opengraphprotocol.us/media/video/train.mp4",
                            SecureUrl = "https://d72cgtgi6hvvl.cloudfront.net/media/video/train.mp4",
                            Type = "video/mp4",
                            Width = 472,
                            Height = 296
                        },
                        new GraphVideo("og:video")
                        {
                            Url ="http://examples.opengraphprotocol.us/media/video/train.webm",
                            SecureUrl = "https://d72cgtgi6hvvl.cloudfront.net/media/video/train.webm",
                            Type ="video/webm",
                            Width = 480,
                            Height = 320
                        },
                    },

                    VideoMovie = new VideoMovie()
                    {
                        ["release_date"] = "1895-12-28",
                        Director = new Profile("video:director")
                        {
                            Url = "http://examples.opengraphprotocol.us/profile.html"
                        },
                        Duration = 50,
                        Tags = new[] { "La Ciotat", "train" }
                    }
                });
    }
}