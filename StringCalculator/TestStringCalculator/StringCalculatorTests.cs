namespace TestStringCalculator
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Should_Return0_ForEmptyString()
        {
            // Arrange

            // Act
            var result = StringCalculator.Add("");

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void Should_ReturnInt_ForStringInput()
        {
            // Arrange

            // Act
            var result = StringCalculator.Add("1");

            // Assert
            result.Should().Be(1);
        }
    }
}