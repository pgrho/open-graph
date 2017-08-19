using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class ProfileTest
    {
        [Fact]
        public void FirstNameTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='profile' />
<meta property='profile:first_name' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Profile);
            Assert.Equal("2003-04-05", target.Profile.FirstName);
        }

        [Fact]
        public void LastNameTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='profile' />
<meta property='profile:last_name' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Profile);
            Assert.Equal("2003-04-05", target.Profile.LastName);
        }

        [Fact]
        public void UserNameTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='profile' />
<meta property='profile:username' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Profile);
            Assert.Equal("2003-04-05", target.Profile.UserName);
        }

        [Fact]
        public void GenderTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='profile' />
<meta property='profile:gender' content='2003-04-05' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Profile);
            Assert.Equal("2003-04-05", target.Profile.Gender);
        }

        [Fact]
        public void RoleTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:actor:role' content='55301' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal(new[] { "55301" }, target.VideoMovie.Actors.Select(a => a.Role));
        }
    }
}