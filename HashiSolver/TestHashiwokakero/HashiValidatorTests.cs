namespace TestHashiwokakero
{
    public class HashiValidatorTests
    {
        [Fact]
        public void Validate_ReturnsFalse_ForEmptyPuzzle()
        {
            // Arrange
            var puzzle = new HashiPuzzle();

            // Act
            var isValid = HashiValidator.Validate(puzzle);

            // Assert
            isValid.Should().BeFalse();
        }

        [Fact]
        public void Validate_ThatEveryIslandHasNeededAmountOfBridges()
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

        [Fact]
        public void Validate_ReturnFalse_IfBridgesAreCrossing()
        {
            // Arrange
            var puzzle = new HashiPuzzle();

            puzzle.AddIsle(1, 0, 1);
            puzzle.AddIsle(1, 1, 0);
            puzzle.AddIsle(1, 2, 1);
            puzzle.AddIsle(1, 1, 2);
            puzzle.AddBridge(0, 2);
            puzzle.AddBridge(1, 2);

            // Act
            var isValid = HashiValidator.Validate(puzzle);

            // Assert
            isValid.Should().BeFalse();
        }
    }
}