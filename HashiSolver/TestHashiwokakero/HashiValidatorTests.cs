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

        [Fact(Skip = "future test")]
        public void Validate_ReturnsTrue_ForValidSolution()
        {
            // Arrange
            var puzzle = new HashiPuzzle();

            // Act
            var isValid = HashiValidator.Validate(puzzle);

            // Assert
            isValid.Should().BeTrue();
        }

        [Fact(Skip = "future test")]
        public void Validate_ReturnsFalse_ForInvalidSolution()
        {
            // Arrange

            // Act

            // Assert

        }
    }
}