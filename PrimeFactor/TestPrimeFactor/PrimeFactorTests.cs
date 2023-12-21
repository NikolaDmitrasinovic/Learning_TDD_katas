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

        [Theory]
        [InlineData(2, new int[] { 2 })]
        [InlineData(4, new int[] { 2, 2 })]
        [InlineData(6, new int[] { 2, 3 })]
        [InlineData(100, new int[] { 2, 2, 5, 5 })]
        public void Should_ReturnPrimeFactors_ForNumber(int number, int[] primeFactors)
        {
            // Arrange

            // Act

            // Assert
            PrimeFactor.Generate(number).Should().BeEquivalentTo(primeFactors);
        }
    }
}