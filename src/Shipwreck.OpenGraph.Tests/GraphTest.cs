using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class GraphTest
    {
        #region Title

        [Fact]
        public void TitleTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Title);
            Assert.True(target.ShouldSerializeTitle());
            Assert.False(target.ShouldSerializeTitles());
        }

        [Fact]
        public void TitlesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:title' content='The Rock' />
<meta property='og:title' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Title);
            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.Titles);
            Assert.False(target.ShouldSerializeTitle());
            Assert.True(target.ShouldSerializeTitles());
        }

        #endregion Title

        #region Type

        [Fact]
        public void TypeTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Type);
            Assert.True(target.ShouldSerializeType());
            Assert.False(target.ShouldSerializeTypes());
        }

        [Fact]
        public void TypesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='The Rock' />
<meta property='og:type' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Type);
            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.Types);
            Assert.False(target.ShouldSerializeType());
            Assert.True(target.ShouldSerializeTypes());
        }

        #endregion Type

        #region Url

        [Fact]
        public void UrlTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:url' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Url);
            Assert.True(target.ShouldSerializeUrl());
            Assert.False(target.ShouldSerializeUrls());
        }

        [Fact]
        public void UrlsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:url' content='The Rock' />
<meta property='og:url' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Url);
            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.Urls);
            Assert.False(target.ShouldSerializeUrl());
            Assert.True(target.ShouldSerializeUrls());
        }

        #endregion Url

        #region Description

        [Fact]
        public void DescriptionTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:description' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Description);
            Assert.True(target.ShouldSerializeDescription());
            Assert.False(target.ShouldSerializeDescriptions());
        }

        [Fact]
        public void DescriptionsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:description' content='The Rock' />
<meta property='og:description' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Description);
            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.Descriptions);
            Assert.False(target.ShouldSerializeDescription());
            Assert.True(target.ShouldSerializeDescriptions());
        }

        #endregion Description

        #region Determiner

        [Fact]
        public void DeterminerTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:determiner' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Determiner);
            Assert.True(target.ShouldSerializeDeterminer());
            Assert.False(target.ShouldSerializeDeterminers());
        }

        [Fact]
        public void DeterminersTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:determiner' content='The Rock' />
<meta property='og:determiner' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Determiner);
            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.Determiners);
            Assert.False(target.ShouldSerializeDeterminer());
            Assert.True(target.ShouldSerializeDeterminers());
        }

        #endregion Determiner

        #region Locale

        [Fact]
        public void LocaleTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:locale' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Locale);
            Assert.True(target.ShouldSerializeLocale());
            Assert.False(target.ShouldSerializeLocales());
        }

        [Fact]
        public void LocalesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:locale' content='The Rock' />
<meta property='og:locale' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Locale);
            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.Locales);
            Assert.False(target.ShouldSerializeLocale());
            Assert.True(target.ShouldSerializeLocales());
        }

        #endregion Locale

        #region AlternateLocale

        [Fact]
        public void AlternateLocaleTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:locale:alternate' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.AlternateLocale);
            Assert.True(target.ShouldSerializeAlternateLocale());
            Assert.False(target.ShouldSerializeAlternateLocales());
        }

        [Fact]
        public void AlternateLocalesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:locale:alternate' content='The Rock' />
<meta property='og:locale:alternate' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.AlternateLocale);
            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.AlternateLocales);
            Assert.False(target.ShouldSerializeAlternateLocale());
            Assert.True(target.ShouldSerializeAlternateLocales());
        }

        #endregion AlternateLocale

        #region SiteName

        [Fact]
        public void SiteNameTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:site_name' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.SiteName);
            Assert.True(target.ShouldSerializeSiteName());
            Assert.False(target.ShouldSerializeSiteNames());
        }

        [Fact]
        public void SiteNamesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:site_name' content='The Rock' />
<meta property='og:site_name' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.SiteName);
            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.SiteNames);
            Assert.False(target.ShouldSerializeSiteName());
            Assert.True(target.ShouldSerializeSiteNames());
        }

        #endregion SiteName

        #region Image

        [Fact]
        public void ImageTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Images?.Select(i => i.Url));
            Assert.False(target.ShouldSerializeImage());
            Assert.True(target.ShouldSerializeImages());
        }

        [Fact]
        public void ImagesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image' content='The Rock' />
<meta property='og:image' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.Images?.Select(i => i.Url));
            Assert.False(target.ShouldSerializeImage());
            Assert.True(target.ShouldSerializeImages());
        }

        #endregion Image
    }
}