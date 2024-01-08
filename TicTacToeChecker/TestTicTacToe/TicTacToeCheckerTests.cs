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

        [Fact]
        public void Should_ReturnOne_ForXVictory()
        {
            // Arrange
            var game = new int[3, 3]
            {
                { 1, 1, 1 },
                { 0, 2, 0 },
                { 0, 0, 2 }
            };

            // Act
            var gameResult = TicTacToeChecker.Check(game);

            // Assert
            gameResult.Should().Be(1);
        }
    }
}