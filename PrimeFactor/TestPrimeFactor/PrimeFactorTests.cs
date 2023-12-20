namespace TestPrimeFactor
{
    public class PrimeFactorTests
    {
        [Fact]
        public void Should_ReturnEmptyList_ForNumbersSmallerThan2()
        {
            // Arrange

            // Act

            // Assert
            PrimeFactor.Generate(1).Should().BeEmpty();
        }
    }
}