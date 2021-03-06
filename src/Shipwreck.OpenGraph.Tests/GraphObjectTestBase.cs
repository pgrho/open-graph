using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
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

        protected void TestXml(string xml, Graph expected)
            => AssertObject(expected, Graph.FromXml(xml));

        protected async Task TestUrl(string url, Graph expected, bool allowUnexpected = true, Action<Graph, Graph> assertion = null)
        {
            // TODO: Network failure must be treated as inconclusive
            Graph actual;
            using (var hc = new HttpClient())
            {
                var html = await hc.GetStringAsync(url).ConfigureAwait(false);
                var hd = new HtmlAgilityPack.HtmlDocument();
                hd.LoadHtml(html);

                actual = Graph.FromXPathNavigable(hd);
            }

            AssertObject(expected, actual, allowUnexpected);
            assertion?.Invoke(expected, actual);
        }

        protected void AssertObject(GraphObject expected, GraphObject actual, bool allowUnexpected = true)
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

                var avs = actual.GetLocalProperties().Where(p => p.Property == pn).ToArray();
                try
                {
                    Assert.Equal(evs, avs);
                }
                catch
                {
                    if (Output != null)
                    {
                        Output.WriteLine($"Assert failed at {pn}");
                        Output.WriteLine("Expected:");
                        foreach (var c in evs)
                        {
                            Output.WriteLine($"    {c}");
                        }
                        Output.WriteLine("Actual:");
                        foreach (var c in avs)
                        {
                            Output.WriteLine($"    {c}");
                        }
                        Output.WriteLine("All Expected Children:");
                        foreach (var c in expected.GetLocalProperties())
                        {
                            Output.WriteLine($"    {c}");
                        }
                        Output.WriteLine("All Actual Children:");
                        foreach (var c in actual.GetLocalProperties())
                        {
                            Output.WriteLine($"    {c}");
                        }
                    }

                    throw;
                }
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
                try
                {
                    Assert.Equal(evs.Length, avs.Length);
                }
                catch
                {
                    if (Output != null)
                    {
                        Output.WriteLine($"Assert failed at {pn}");
                        Output.WriteLine("Expected:");
                        foreach (var c in evs)
                        {
                            Output.WriteLine($"    {c.Path}: {c}");
                        }
                        Output.WriteLine("Actual:");
                        foreach (var c in avs)
                        {
                            Output.WriteLine($"    {c.Path}: {c}");
                        }
                        Output.WriteLine("All Expected Children:");
                        foreach (var c in evs)
                        {
                            Output.WriteLine($"    {c.Path}: {c}");
                        }
                        Output.WriteLine("All Actual Children:");
                        foreach (var c in avs)
                        {
                            Output.WriteLine($"    {c.Path}: {c}");
                        }
                    }

                    throw;
                }
                for (int i = 0; i < evs.Length; i++)
                {
                    AssertObject(evs[i], avs[i], allowUnexpected);
                }
            }

            var to = (expected as Graph)?.TypeObject;
            var ato = (actual as Graph)?.TypeObject;
            if (to != null)
            {
                AssertObject(to, ato, allowUnexpected);
            }
            else if (!allowUnexpected)
            {
                Assert.Null(ato);
            }
        }
    }
}