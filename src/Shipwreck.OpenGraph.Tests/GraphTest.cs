﻿using System.Linq;
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