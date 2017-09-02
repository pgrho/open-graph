using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class MixiTest : GraphObjectTestBase
    {
        public MixiTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public Task ContentRatingTest()
            => TestUrl("http://www.dlsite.com/pro/work/=/product_id/VJ008001.html", new Graph()
            {
                [Mixi.ContentRating] = "1"
            });
    }
}