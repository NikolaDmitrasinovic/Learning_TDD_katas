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
            var game = new Game();
            var player1 = new Player();

            // Act
            player1.PlayerScores();

            // Assert
            game.CalculateScore().Should().Be("15-love");
        }
    }
}