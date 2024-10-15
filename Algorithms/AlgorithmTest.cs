using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        #region GetFactorial Tests
        [Fact]
        public void CanGetFactorial()
        {
            Assert.Equal(24, Algorithms.GetFactorial(4));
        }

        #endregion

        #region FormatSeparators Tests

        [Fact]
        public void CanFormatSeparators()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
        }

        [Fact]
        public void CanFormatEmptyList()
        {
            Assert.Equal("", Algorithms.FormatSeparators());
        }

        [Fact]
        public void CanFormatEmptyString()
        {
            Assert.Equal("", Algorithms.FormatSeparators(""));
        }

        [Fact]
        public void CanFormatStringWithEmptyParam()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "", "c"));
        }

        [Fact]
        public void CanFormatStringWithWhitespaceParam()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", " ", "c"));
        }

        [Fact]
        public void CanFormatStringWithFirstWhitespaceParam()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators(" ", "a", "b", "c"));
        }

        [Fact]
        public void CanFormatStringWithLastWhitespaceParam()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c", " "));
        }

        #endregion
    }
}