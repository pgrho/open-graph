using System.Linq;
using System.Net.Http;
using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public abstract class GraphObjectTestBase
    {
        internal readonly ITestOutputHelper Output;

        internal GraphObjectTestBase(ITestOutputHelper output = null)
        {
            Output = output;
        }

        protected void TestUrl(string url, Graph expected)
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

        protected void AssertObject(GraphObject expected, GraphObject actual)
        {
            Assert.Equal(expected.GetType(), actual.GetType());
            Assert.Equal(expected.Path, actual.Path);

            foreach (var pn in expected.GetLocalProperties().Concat(actual.GetLocalProperties()).Select(p => p.Property).Distinct())
            {
                var evs = expected.GetLocalProperties().Where(p => p.Property == pn).ToArray();

                if (!evs.Any())
                {
                    Output?.WriteLine($"Unexpected property: {pn} at {actual.Path}");
                    continue;
                }

                Assert.Equal(evs, actual.GetLocalProperties().Where(p => p.Property == pn));
            }

            foreach (var pn in expected.Children.Concat(actual.Children).Select(p => p.Path).Distinct())
            {
                var evs = expected.Children.Where(p => p.Path == pn).ToArray();

                if (!evs.Any())
                {
                    Output?.WriteLine($"Unexpected child: {pn}");
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
    }
}