using FluentAssertions;
using static HumanReadableTime.Library.HumanReadableTime;

namespace HumanReadableTime.Tests
{
    public class HumanReadableTimeTests
    {
        [Fact]
        public void Should_ReturnStartTime_For0Seconds()
        {
            // Arrange

            // Act
            var readableTime = GetReadableTime(0);

            // Assert
            readableTime.Should().Be("00:00:00");
        }

        [Fact]
        public void Should_ReturnCorrectTime_For5Seconds()
        {
            // Arrange

            // Act
            var readableTime = GetReadableTime(5);

            // Assert
            readableTime.Should().Be("00:00:05");
        }

        [Fact]
        public void Should_ReturnMinutes_ForOver59SecondsInput()
        {
            // Arrange

            // Act
            var readableTime = GetReadableTime(60);

            // Assert
            readableTime.Should().Be("00:01:00");
        }
    }
}

//Assert.AreEqual(TimeFormat.GetReadableTime(86399),23:59:59);
//Assert.AreEqual(TimeFormat.GetReadableTime(359999),99:59:59);