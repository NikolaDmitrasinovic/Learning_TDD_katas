using ClassLibraryLeapYear;
using FluentAssertions;

namespace TestLeapYear
{
    public class LeapYearTests
    {
        [Fact]
        public void Should_ReturnFalse_ForCommonYear()
        {
            // Arrange

            // Act

            // Assert
            LeapYear.IsLeapYear(2001).Should().BeFalse();
        }

        [Fact]
        public void Should_ReturnTrue_ForCommonLeapYear()
        {
            // Arrange

            // Act

            // Assert
            LeapYear.IsLeapYear(1996).Should().BeTrue();
        }
    }
}