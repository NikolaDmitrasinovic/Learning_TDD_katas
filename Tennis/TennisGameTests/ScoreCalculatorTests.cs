using FluentAssertions;
using TennisGame;

namespace TennisGameTests
{
    public class ScoreCalculatorTests
    {
        [Theory]
        [InlineData(0, 0, "love-love")]
        [InlineData(1, 1, "15-15")]
        [InlineData(2, 2, "30-30")]
        [InlineData(3, 0, "40-love")]
        public void Should_ConvertIntScore_ToTennisScore(int player1Score, int player2Score, string convertedScore)
        {
            // Arrange

            // Act

            // Assert
            ScoreCalculator.Calculate(player1Score, player2Score).Should().Be(convertedScore);
        }

        [Fact]
        public void Should_ShowScoreAsDeuce_ForPlayersTiedAt40()
        {
            // Arrange

            // Act

            // Assert
            ScoreCalculator.Calculate(3, 3).Should().Be("deuce");
        }        

        [Fact]
        public void Should_ShowAdvantage_ForLeadingPlayer()
        {
            // Arrange

            // Act

            // Assert
            ScoreCalculator.Calculate(4, 3).Should().Be("player1 AD");
        }
    }
}
