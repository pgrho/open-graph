using System;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class BookTest : GraphObjectTestBase
    {
        public BookTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# book: http://ogp.me/ns/book#'>
  <meta property='fb:app_id' content='302184056577324' /> 
  <meta property='og:type'   content='book' /> 
  <meta property='og:url'    content='Put your own URL to the object here' /> 
  <meta property='og:title'  content='Sample Book' /> 
  <meta property='og:image'  content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /> </head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "book",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Book",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    Book = new Book
                    {

                    }
                });

        #region Author

        [Fact]
        public void AuthorTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='book' />
<meta property='book:author' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Book);
            Assert.Equal(new[] { "55301" }, target.Book.Authors.Select(a => a.Url));
        }

        [Fact]
        public void AuthorsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='book' />
<meta property='book:author' content='55301' />
<meta property='book:author' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Book);
            Assert.Equal(new[] { "55301", "100puri" }, target.Book.Authors.Select(a => a.Url));
        }

        #endregion Author

        [Fact]
        public void SectionTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='book' />
<meta property='book:isbn' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Book);
            Assert.Equal("2003-04-05", target.Book.ISBN);
        }

        [Fact]
        public void ReleaseDateTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='book' />
<meta property='book:release_date' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Book);
            Assert.Equal(new DateTime(2003, 4, 5), target.Book.ReleaseDate);
        }

        #region Tag

        [Fact]
        public void TagTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='book' />
<meta property='book:tag' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Book);
            Assert.Equal(new[] { "55301" }, target.Book.Tags);
        }

        [Fact]
        public void TagsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='book' />
<meta property='book:tag' content='55301' />
<meta property='book:tag' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Book);
            Assert.Equal(new[] { "55301", "100puri" }, target.Book.Tags);
        }

        #endregion Tag
    }
}