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
        [InlineData(new int[] { 2 }, "even")]
        public void Should_ReturnEvenOrOdd_ForOneElementArray(int[] intsArray, string result)
        {
            // Arrange

            // Act

            // Assert
            EvenOrOdd.OddOrEven(intsArray).Should().Be(result);
        }

        [Theory]
        [InlineData(new int[] { 4, 2, 3 }, "odd")]
        //[InlineData(new int[] { 1, 3, 2 }, "even")]
        public void Should_ReturnEvenOrOdd_ForSumOftArrayElements(int[] intsArray, string result)
        {
            // Arrange

            // Act

            // Assert
            EvenOrOdd.OddOrEven(intsArray).Should().Be(result);
        }
    }
}