using Regex102.Application.Errors;
using Regex102.Application.UseCases.Matches;
using Xunit;


namespace Regex102.Application.Tests.Matches
{
    public class MatchRegexTests
    {
        private readonly MatchRegex _regexMatcher;

        public MatchRegexTests()
        {
            _regexMatcher = new MatchRegex();
        }

        [Fact]
        public void IsMatch_WithValidPattern_ReturnsTrue()
        {
            // Arrange
            var input = "Hello World";
            var pattern = "Hello";

            // Act
            var result = _regexMatcher.IsMatch(input, pattern);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsMatch_WithInvalidPattern_ThrowsInvalidRegExFormatException()
        {
            // Arrange
            var input = "Hello World";
            var pattern = "Hello(";

            // Act
            void act() => _regexMatcher.IsMatch(input, pattern);

            // Assert
            Assert.Throws<InvalidRegExFormatException>(act);
        }
    }
}
