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
        public void Should_ReturnVictor_ForRow(int victor)
        {
            // Arrange
            var game = new int[3, 3]
            {
                { victor, victor, victor},
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            // Act
            var gameResult = TicTacToeChecker.Check(game);

            // Assert
            gameResult.Should().Be(victor);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Should_ReturnVictor_ForColumn(int victor)
        {
            // Arrange
            var game = new int[3, 3]
            {
                { 0, 0, victor},
                { 0, 0, victor },
                { 0, 0, victor }
            };

            // Act
            var gameResult = TicTacToeChecker.Check(game);

            // Assert
            gameResult.Should().Be(victor);
        }
    }
}