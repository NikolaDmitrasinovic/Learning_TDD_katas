using BowlingGame;
using FluentAssertions;

namespace BowlingGameTest
{
    public class BowlingGameTests
    {
        private Game game = new();

        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }

        [Fact]
        public void Shoud_SolveGutterGame()
        {
            // Arrange
            var rolls = 20;
            var pins = 0;

            // Act
            RollMany(20, 0);

            // Assert
            game.Score().Should().Be(0);
        }        

        [Fact]
        public void Shoud_ResolveScore_ForAllOnes()
        {
            // Arrange

            // Act
            RollMany(20, 1);

            // Assert
            game.Score().Should().Be(20);
        }

        [Fact]
        public void Shoud_ResolveScore_ForOneSpare()
        {
            // Arrange

            // Act
            RollSpare();
            game.Roll(3);
            RollMany(17, 0);

            // Assert
            game.Score().Should().Be(16);
        }

        [Fact]
        public void Shoud_ResolveScore_ForOneStrike()
        {
            // Arrange

            // Act            
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMany(16, 0);

            // Assert
            game.Score().Should().Be(24);
        }

        private void RollSpare()
        {
            game.Roll(5);
            game.Roll(5);
        }
    }
}