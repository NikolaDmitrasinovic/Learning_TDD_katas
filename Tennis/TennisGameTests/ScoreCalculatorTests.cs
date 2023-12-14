using FluentAssertions;
using TennisGame;

namespace TennisGameTests
{
    public class ScoreCalculatorTests
    {
        private static void PlayerScore(Player player, int score)
        {
            for (int i = 0; i < score; i++)
            {
                player.PlayerScores();
            }
        }

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
        public void Should_ShowScoreAsDeuce_ForPlayerTiedAt40()
        {
            // Arrange
            var player1 = new Player();
            var player2 = new Player();

            // Act
            PlayerScore(player1, 3);
            PlayerScore(player2, 3);

            // Assert
            ScoreCalculator.Calculate(player1.Score, player2.Score).Should().Be("deuce");
        }

        [Fact]
        public void Should_ShowAdvantage_ForLeadingPlayer()
        {
            // Arrange
            var player1 = new Player();
            var player2 = new Player();

            // Act
            PlayerScore(player1, 4);
            PlayerScore(player2, 3);

            // Assert
            ScoreCalculator.Calculate(player1.Score, player2.Score).Should().Be("player1 AD");
        }
    }
}
