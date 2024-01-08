namespace TestTicTacToe
{
    public class TicTacToeCheckerTests
    {
        [Fact]
        public void Should_ReturnNegativeOne_ForUnsolvedGame()
        {
            // Arrange
            var game = new int[3, 3]
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            // Act
            var gameResult = TicTacToeChecker.Check(game);

            // Assert
            gameResult.Should().Be(-1);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Should_ReturnVictor_ForFirstRowVictory(int victor)
        {
            // Arrange
            var game = new int[3, 3]
            {
                { victor, victor, victor},
                { 0, 2, 0 },
                { 0, 0, 2 }
            };

            // Act
            var gameResult = TicTacToeChecker.Check(game);

            // Assert
            gameResult.Should().Be(victor);
        }

        [Fact]
        public void Should_ReturnOne_ForXSecondRowVicotry()
        {
            // Arrange
            var game = new int[3, 3]
            {
                { 0, 2, 2 },
                { 1, 1, 1 },
                { 0, 0, 0 }
            };

            // Act
            var gameResult = TicTacToeChecker.Check(game);

            // Assert
            gameResult.Should().Be(1);
        }

        [Fact]
        public void Should_ReturnOne_ForXThirdRowVicotry()
        {
            // Arrange
            var game = new int[3, 3]
            {
                { 0, 2, 2 },
                { 0, 0, 0 },
                { 1, 1, 1 }
            };

            // Act
            var gameResult = TicTacToeChecker.Check(game);

            // Assert
            gameResult.Should().Be(1);
        }
    }
}