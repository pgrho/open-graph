using Xunit;

namespace Shipwreck.OpenGraph
{
    public class PropertyNameTest
    {
        #region StartsWithTest_Combined

        [Fact]
        public void StartsWithTest_Combined_DifferenceNamespace()
        {
            Assert.False(new PropertyName("a", "b").StartsWith(new PropertyName("b"), "b", out var matched));
            Assert.False(matched);
        }

        [Fact]
        public void StartsWithTest_Combined_Match()
        {
            Assert.True(new PropertyName("a", "b").StartsWith(new PropertyName("a"), "b", out var matched));
            Assert.True(matched);
        }

        [Fact]
        public void StartsWithTest_Combined_StartsWith()
        {
            Assert.True(new PropertyName("a", "b:c").StartsWith(new PropertyName("a"), "b", out var matched));
            Assert.False(matched);
        }

        [Fact]
        public void StartsWithTest_Combined_NoSeparator()
        {
            Assert.False(new PropertyName("a", "bc").StartsWith(new PropertyName("a"), "b", out var matched));
            Assert.False(matched);
        }

        #endregion StartsWithTest_Combined
    }
}