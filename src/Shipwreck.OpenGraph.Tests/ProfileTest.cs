using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class ProfileTest : GraphObjectTestBase
    {
        public ProfileTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ReferenceSampleTest()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# profile: http://ogp.me/ns/profile#'>
  <meta property='fb:app_id' content='302184056577324' /> 
  <meta property='og:type'   content='profile' /> 
  <meta property='og:url'    content='Put your own URL to the object here' /> 
  <meta property='og:title'  content='Sample Profile' /> 
  <meta property='og:image'  content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' /></head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "profile",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Profile",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    Profile = new Profile
                    {

                    }
                });
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