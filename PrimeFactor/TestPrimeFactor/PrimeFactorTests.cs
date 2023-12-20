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

        [Fact]
        public void Should_Return2AsPrimeFactor_ForNumber2()
        {
            // Arrange

            // Act

            // Assert
            PrimeFactor.Generate(2).Should().BeEquivalentTo([2]);
        }

        [Fact]
        public void Should_ReturnPrimeFactors_ForNumber4()
        {
            // Arrange

            // Act

            // Assert
            PrimeFactor.Generate(4).Should().BeEquivalentTo([2, 2]);
        }

        [Fact]
        public void Should_ReturnPrimeFactors_ForNumber6()
        {
            // Arrange

            // Act

            // Assert
            PrimeFactor.Generate(6).Should().BeEquivalentTo([5]);
        }
    }
}