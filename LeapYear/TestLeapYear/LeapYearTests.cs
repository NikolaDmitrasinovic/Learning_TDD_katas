using ClassLibraryLeapYear;
using FluentAssertions;

namespace TestLeapYear
{
    public class LeapYearTests
    {
        [Theory]
        [InlineData(2001, false)]
        [InlineData(1996, true)]
        [InlineData(1900, false)]
        [InlineData(2000, true)]
        public void Should_ReturnFalse_ForCommonYear(int year, bool isLeapYear)
        {
            // Arrange

            // Act

            // Assert
            LeapYear.IsLeapYear(year).Should().Be(isLeapYear);
        }
    }
}