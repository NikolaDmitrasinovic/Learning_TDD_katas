using BowlingGame;
using FluentAssertions;

namespace BowlingGameTest
{
    public class BowlingGameTests
    {
        [Fact]
        public void Shoud_SolveGutterGame()
        {
            // Arrange
            var game = new Game();

            // Act
            for(int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            // Assert
            game.Score().Should().Be(0);
        }

        [Fact]
        public void Shoud_ResolveScore_ForAllOnes()
        {
            // Arrange
            var game = new Game();

            // Act
            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            // Assert
            game.Score().Should().Be(20);
        }
    }
}