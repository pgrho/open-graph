using Xunit;

namespace Shipwreck.OpenGraph
{
    public class PropertyNameTest
    {
        #region StartsWithTest_Combined

        [Fact]
        public void StartsWithTest_Combined_DifferenceNamespace()
        {
            Assert.False(new PropertyPath("a", "b").StartsWith(new PropertyPath("b"), "b", out var matched));
            Assert.False(matched);
        }

        [Fact]
        public void StartsWithTest_Combined_Match()
        {
            Assert.True(new PropertyPath("a", "b").StartsWith(new PropertyPath("a"), "b", out var matched));
            Assert.True(matched);
        }

        [Fact]
        public void StartsWithTest_Combined_StartsWith()
        {
            Assert.True(new PropertyPath("a", "b:c").StartsWith(new PropertyPath("a"), "b", out var matched));
            Assert.False(matched);
        }

        [Fact]
        public void StartsWithTest_Combined_NoSeparator()
        {
            Assert.False(new PropertyPath("a", "bc").StartsWith(new PropertyPath("a"), "b", out var matched));
            Assert.False(matched);
        }

        #endregion StartsWithTest_Combined
    }
}