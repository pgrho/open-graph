using System;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class ArticleTest : GraphObjectTestBase
    {
        public ArticleTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html><head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# article: http://ogp.me/ns/article#'>
  <meta property='fb:app_id' content='302184056577324' /> 
  <meta property='og:type'   content='article' /> 
  <meta property='og:url'    content='Put your own URL to the object here' /> 
  <meta property='og:title'  content='Sample Article' /> 
  <meta property='og:image'  content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /></head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "article",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Article",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    Article = new Article()
                });

        [Fact]
        public void PublishedTimeTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='article' />
<meta property='article:published_time' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Article);
            Assert.Equal(new DateTime(2003, 4, 5), target.Article.PublishedTime);
        }

        [Fact]
        public void ModifiedTimeTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='article' />
<meta property='article:modified_time' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Article);
            Assert.Equal(new DateTime(2003, 4, 5), target.Article.ModifiedTime);
        }

        [Fact]
        public void ExpirationTimeTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='article' />
<meta property='article:expiration_time' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Article);
            Assert.Equal(new DateTime(2003, 4, 5), target.Article.ExpirationTime);
        }

        #region Author

        [Fact]
        public void AuthorTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='article' />
<meta property='article:author' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Article);
            Assert.Equal(new[] { "55301" }, target.Article.Authors.Select(a => a.Url));
        }

        [Fact]
        public void AuthorsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='article' />
<meta property='article:author' content='55301' />
<meta property='article:author' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Article);
            Assert.Equal(new[] { "55301", "100puri" }, target.Article.Authors.Select(a => a.Url));
        }

        #endregion Author

        [Fact]
        public void SectionTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='article' />
<meta property='article:section' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Article);
            Assert.Equal("2003-04-05", target.Article.Section);
        }

        #region Tag

        [Fact]
        public void TagTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='article' />
<meta property='article:tag' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Article);
            Assert.Equal(new[] { "55301" }, target.Article.Tags);
        }

        [Fact]
        public void TagsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='article' />
<meta property='article:tag' content='55301' />
<meta property='article:tag' content='100puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Article);
            Assert.Equal(new[] { "55301", "100puri" }, target.Article.Tags);
        }

        #endregion Tag
    }
}