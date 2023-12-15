namespace TestEvenOrOdd
{
    public class EvenOrOddTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
            EvenOrOdd.OddOrEven([]).Should().Be("even");
        }
    }
}