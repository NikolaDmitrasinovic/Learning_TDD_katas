using FluentAssertions;
using TennisGame;

namespace TennisGameTests
{
    public class ScoreConverterTests
    {
        [Theory]
        [InlineData(0, "love")]
        [InlineData(1, "15")]
        [InlineData(2, "30")]
        [InlineData(3, "40")]
        public void Should_ConvertIntScore_ToTennisScore(int score, string convertedScore)
        {
            // Arrange

            // Act

            // Assert
            ScoreConverter.Convert(score).Should().Be(convertedScore);
        }
    }
}
