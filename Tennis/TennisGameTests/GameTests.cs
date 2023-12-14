using FluentAssertions;
using TennisGame;

namespace TennisGameTests
{
    public class GameTests
    {
        [Theory]
        [InlineData(1, 0, "15-love")]
        [InlineData(2, 2, "30-30")]
        [InlineData(3, 2, "40-30")]
        public void Should_ReturnScore_ForGame(int player1Score, int player2Score, string result)
        {
            // Arrange
            var player1 = new Player();
            var player2 = new Player();
            var game = new Game(player1, player2);

            // Act
            PlayerScore(player1, player1Score);
            PlayerScore(player2, player2Score);

            // Assert
            game.CalculateScore().Should().Be(result);
        }

        [Fact]
        public void Should_ShowScoreAsDeuce_ForPlayerTiedAt40()
        {
            // Arrange
            var player1 = new Player();
            var player2 = new Player();
            var game = new Game(player1, player2);

            // Act
            PlayerScore(player1, 3);
            PlayerScore(player2, 3);

            // Assert
            game.CalculateScore().Should().Be("deuce");
        }

        [Fact]
        public void Should_ShowAdvantage_ForLeadingPlayer()
        {
            // Arrange
            var player1 = new Player();
            var player2 = new Player();
            var game = new Game(player1, player2);

            // Act
            PlayerScore(player1, 4);
            PlayerScore(player2, 3);

            // Assert
            game.CalculateScore().Should().Be("player1 AD");
        }

        private static void PlayerScore(Player player, int score)
        {
            for (int i = 0; i < score; i++)
            {
                player.PlayerScores();
            }
        }
    }
}