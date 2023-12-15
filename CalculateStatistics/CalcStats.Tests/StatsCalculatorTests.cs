using FluentAssertions;

namespace CalcStats.Tests
{
    public class StatsCalculatorTests
    {
        private readonly Library.StatsCalculator calcStats = new([1, 2, 6, -4, 14, -1]);

        [Fact]
        public void Should_ReturnMinimum_ForIntsArray()
        {
            // Arrange            

            // Act

            // Assert
            calcStats.Minimum.Should().Be(-4);
        }

        [Fact]
        public void Should_ReturnMaximum_ForIntsArray()
        {
            // Arrange

            // Act

            // Assert
            calcStats.Maximum.Should().Be(14);
        }

        [Fact]
        public void Should_ReturnNumberOfElements_InIntsArray()
        {
            // Arrange

            // Act

            // Assert
            calcStats.NumberOfElements.Should().Be(6);
        }

        [Fact]
        public void Should_ReturnAverageValue_ForIntsArray()
        {
            // Arrange

            // Act

            // Assert
            calcStats.AverageValue.Should().Be(3);
        }
    }
}