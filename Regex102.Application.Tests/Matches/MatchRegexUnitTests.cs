using Regex102.Application.Errors;
using Regex102.Application.UseCases.Matches;
using Xunit;


namespace Regex102.Application.UnitTests.Matches
{
    public class MatchRegexUnitTests
    {

        [Fact]
        public void IsMatch_WithValidPattern_ReturnsTrue()
        {
            // Arrange
            var input = "Hello World";
            var pattern = "Hello";
            var _regexMatcher = new MatchRegex();

            // Act
            var result = _regexMatcher.IsMatch(input, pattern);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsMatch_WithUnMatcheddPattern_ReturnsFalse()
        {
            // Arrange
            var input = "No Match";
            var pattern = "Hello";
            var _regexMatcher = new MatchRegex();

            // Act
            var result = _regexMatcher.IsMatch(input, pattern);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsMatch_WithInvalidPattern_ThrowsInvalidRegExFormatException()
        {
            // Arrange
            var input = "Hello World";
            var pattern = "Hello(";
            var _regexMatcher = new MatchRegex();

            // Act
            void act() => _regexMatcher.IsMatch(input, pattern);

            // Assert
            Assert.Throws<InvalidRegExFormatException>(act);
        }
    }
}
