namespace TestEvenOrOdd
{
    public class EvenOrOddTests
    {
        [Fact]
        public void Should_ReturnEven_ForEmptyArray()
        {
            // Arrange

            // Act

            // Assert
            EvenOrOdd.OddOrEven([]).Should().Be("even");
        }

        [Theory]
        [InlineData(new int[] { 1 }, "odd")]
        public void Should_ReturnEvenOrOdd_ForOneElementArray(int[] intsArray, string result)
        {
            // Arrange

            // Act

            // Assert
            EvenOrOdd.OddOrEven(intsArray).Should().Be(result);
        }
    }
}