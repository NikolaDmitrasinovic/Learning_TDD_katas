using FluentAssertions;
using TennisGame;

namespace TennisGameTests
{
    public class GameTests
    {
        [Fact]
        public void Should_ScoreFirstPoint_ForPlayer1()
        {
            // Arrange
            var player1 = new Player();
            var player2 = new Player();
            var game = new Game(player1, player2);

            // Act
            PlayerScore(player1, 1);

            // Assert
            game.CalculateScore().Should().Be("15-love");
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