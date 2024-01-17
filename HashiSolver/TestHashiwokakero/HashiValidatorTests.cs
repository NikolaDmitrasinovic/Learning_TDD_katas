namespace TestHashiwokakero
{
    public class HashiValidatorTests
    {
        [Fact]
        public void Validate_IfEveryIslandHasNeededAmountOfBridges()
        {
            // Arrange
            var puzzle = new HashiPuzzle();

            puzzle.AddIsle(1, 0, 0);
            puzzle.AddIsle(1, 0, 1);
            puzzle.AddIsle(2, 1, 0);
            puzzle.AddIsle(2, 1, 1);
            puzzle.AddBridge(0, 2);
            puzzle.AddBridge(1, 3);
            puzzle.AddBridge(2, 3);

            // Act
            var isValid = HashiValidator.Validate(puzzle);

            // Assert
            isValid.Should().BeTrue();
        }

        [Theory]
        [InlineData(0, false)]
        [InlineData(5, true)]
        public void Validate_IfBridgesCross(int isle1X, bool result)
        {
            // Arrange
            var puzzle = new HashiPuzzle();

            puzzle.AddIsle(1, isle1X, 1);
            puzzle.AddIsle(1, 2, 1);
            puzzle.AddIsle(1, 1, 0);
            puzzle.AddIsle(1, 1, 2);
            puzzle.AddBridge(0, 1);
            puzzle.AddBridge(2, 3);

            // Act
            var isValid = HashiValidator.Validate(puzzle);

            // Assert
            isValid.Should().Be(result);
        }

        [Theory]
        [InlineData(0, 1, 0, 2, 0, 3)]
        [InlineData(1, 0, 2, 0, 3, 0)]
        public void Validate_IfBridgesAreCrossingIsles(int isle1X, int isle1Y, int isle2X, int isle2Y, int isle3X, int isle3Y)
        {
            // Arrange
            var puzzle = new HashiPuzzle();

            puzzle.AddIsle(1, isle1X, isle1Y);
            puzzle.AddIsle(1, isle2X, isle2Y);
            puzzle.AddIsle(2, isle3X, isle3Y);
            puzzle.AddBridge(0, 2);
            puzzle.AddBridge(1, 2);

            // Act
            var isValid = HashiValidator.Validate(puzzle);

            // Assert
            isValid.Should().BeFalse();
        }

        [Fact]
        public void Validate_AtMostTwoBridgesConnectAPairOfIslands()
        {
            // Arrange
            var puzzle = new HashiPuzzle();

            puzzle.AddIsle(3, 0, 0);
            puzzle.AddIsle(3, 0, 1);
            puzzle.AddBridge(0, 1);
            puzzle.AddBridge(0, 1);
            puzzle.AddBridge(0, 1);

            // Act
            var isValid = HashiValidator.Validate(puzzle);

            // Assert
            isValid.Should().BeFalse();
        }
    }
}