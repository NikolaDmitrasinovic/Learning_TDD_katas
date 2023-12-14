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
    }
}
