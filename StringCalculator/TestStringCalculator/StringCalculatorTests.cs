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
    }
}