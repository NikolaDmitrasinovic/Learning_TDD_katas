using FluentAssertions;
using TennisGame;

namespace TennisGameTests
{
    public class ScoreConverterTests
    {
        [Fact]
        public void Should_Convert0_ToLove()
        {
            // Arrange

            // Act

            // Assert
            ScoreConverter.Convert(0).Should().Be("love");
        }

        [Fact]
        public void Should_Convert1_To15()
        {
            // Arrange

            // Act

            // Assert
            ScoreConverter.Convert(1).Should().Be("15");
        }
    }
}
