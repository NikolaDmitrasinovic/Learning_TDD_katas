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

        [Fact]
        public void Should_ReturnSum_For2NumbersStringInput()
        {
            // Arrange

            // Act
            var result = StringCalculator.Add("1,2");

            // Assert
            result.Should().Be(3);
        }

        [Fact]
        public void Should_ReturnSum_ForNumbersStringInput()
        {
            // Arrange

            // Act
            var result = StringCalculator.Add("1,2,3,20");

            // Assert
            result.Should().Be(26);
        }
    }
}