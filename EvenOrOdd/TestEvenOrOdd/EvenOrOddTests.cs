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
    }
}