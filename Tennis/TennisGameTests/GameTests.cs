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
            player1.PlayerScores();

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
            player1.PlayerScores();
            player1.PlayerScores();
            player1.PlayerScores();

            player2.PlayerScores();
            player2.PlayerScores();
            player2.PlayerScores();

            // Assert
            game.CalculateScore().Should().Be("deuce");
        }
    }
}