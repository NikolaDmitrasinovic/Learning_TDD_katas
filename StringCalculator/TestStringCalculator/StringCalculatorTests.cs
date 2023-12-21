using System.ComponentModel;

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

        [Theory]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        [InlineData("1,2,3", 6)]
        public void Should_ReturnInt_ForStringInput(string numbersString, int expectedSum)
        {
            // Arrange

            // Act
            var result = StringCalculator.Add(numbersString);

            // Assert
            result.Should().Be(expectedSum);
        }

        [Fact]
        public void Should_HandleNewLines()
        {
            // Arrange

            // Act
            var result = StringCalculator.Add("1\n2,3");

            // Assert
            result.Should().Be(6);
        }

        [Fact]
        public void Should_SupportDifferentDelimiters()
        {
            // Arrange

            // Act
            var result = StringCalculator.Add("//;\n1;2");

            // Assert
            result.Should().Be(3);
        }

        [Fact]
        public void Should_ThrowException_ForNegativeNumbers()
        {
            // Arrange
            var numbers = "-1,2,-3";

            // Act

            // Assert
            typeof(StringCalculator).Invoking(x => StringCalculator.Add(numbers))
                .Should()
                .Throw<ArgumentException>()
                .WithMessage("negatives not allowed (-1)(-3)");
        }
    }
}