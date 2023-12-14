using FluentAssertions;
using static HumanReadableTime.Library.HumanReadableTime;

namespace HumanReadableTime.Tests
{
    public class HumanReadableTimeTests
    {
        [Theory]
        [InlineData(0, "00:00:00")]
        [InlineData(5, "00:00:05")]
        [InlineData(60, "00:01:00")]
        [InlineData(86_399, "23:59:59")]
        [InlineData(359_999, "99:59:59")]
        public void Should_ReturnReadableTime_ForInputInSeconds(int input, string result)
        {
            // Arrange

            // Act

            // Assert
            GetReadableTime(input).Should().Be(result);
        }
    }
}