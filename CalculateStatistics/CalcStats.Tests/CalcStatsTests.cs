using FluentAssertions;

namespace CalcStats.Tests
{
    public class CalcStatsTests
    {
        [Fact]
        public void Should_ReturnMinimum_ForIntsArray()
        {
            // Arrange
            var sequence = new Library.CalcStats([1, 2, 6, -4, 14, -1]);

            // Act
            var minimumValue = sequence.Minimum();

            // Assert
            minimumValue.Should().Be(-4);
        }

        [Fact]
        public void Should_ReturnMaximum_ForIntsArray()
        {
            // Arrange
            var sequence = new Library.CalcStats([1, 2, 6, -4, 14, -1]);

            // Act
            var minimumValue = sequence.Maximum();

            // Assert
            minimumValue.Should().Be(14);
        }
    }
}