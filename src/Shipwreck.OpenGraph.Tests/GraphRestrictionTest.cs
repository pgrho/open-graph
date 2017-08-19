using Xunit;

namespace Shipwreck.OpenGraph
{
    public class GraphRestrictionTest
    {
        #region AllowedCountry

        [Fact]
        public void AllowedCountryTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:restrictions:country:allowed' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Restriction.AllowedContry);
            Assert.Equal(new[] { "The Rock" }, target.Restriction.AllowedCountries);
        }

        [Fact]
        public void AllowedCountriesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:restrictions:country:allowed' content='The Rock' />
<meta property='og:restrictions:country:allowed' content='alcohol' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Restriction.AllowedContry);
            Assert.Equal(new[] { "The Rock", "alcohol" }, target.Restriction.AllowedCountries);
        }

        #endregion AllowedCountry

        #region DisallowedCountry

        [Fact]
        public void DisallowedCountryTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:restrictions:country:disallowed' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Restriction.DisallowedContry);
            Assert.Equal(new[] { "The Rock" }, target.Restriction.DisallowedCountries);
        }

        [Fact]
        public void DisallowedCountriesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:restrictions:country:disallowed' content='The Rock' />
<meta property='og:restrictions:country:disallowed' content='alcohol' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Restriction.DisallowedContry);
            Assert.Equal(new[] { "The Rock", "alcohol" }, target.Restriction.DisallowedCountries);
        }

        #endregion DisallowedCountry

        [Fact]
        public void AgeTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:restrictions:age' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Restriction.Age);
        }

        #region Content

        [Fact]
        public void ContentTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:restrictions:content' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Restriction.Content);
            Assert.Equal(new[] { "The Rock" }, target.Restriction.Contents);
        }

        [Fact]
        public void ContentsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:restrictions:content' content='The Rock' />
<meta property='og:restrictions:content' content='alcohol' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Restriction.Content);
            Assert.Equal(new[] { "The Rock", "alcohol" }, target.Restriction.Contents);
        }

        #endregion Content
    }
}