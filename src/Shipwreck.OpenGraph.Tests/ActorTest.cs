using System.Linq;
using Xunit;

namespace Shipwreck.OpenGraph
{
    public class ActorTest
    {
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