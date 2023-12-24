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
        public void Should_ReturnSumOfNumbers_ForStringInput(string numbersString, int expectedSum)
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

        [Theory]
        [InlineData("//;\n2;2", 4)]
        [InlineData("//[***]\n1***1***1", 3)]
        [InlineData("//[*][&]\n1*2&3", 6)]
        [InlineData("//[**][&&&&]\n2*4&4", 10)]
        public void Should_HandleDifferentDelimiters(string input, int result)
        {
            // Arrange

            // Act
            var sumOfNumbers = StringCalculator.Add(input);

            // Assert
            sumOfNumbers.Should().Be(result);
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

        [Fact]
        public void Should_IgnoreNumbersBiggerThan1000()
        {
            // Arrange

            // Act
            var result = StringCalculator.Add("32145,3");

            // Assert
            result.Should().Be(3);
        }
    }
}