namespace TestListComparator
{
    public class ListComparatorTests
    {
        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 2)]
        public void Should_ReturnNumberOfSameElements_ForArrayComparedtoItself(int[] intsArray, int result)
        {
            // Arrange

            // Act
            var numberOfSameElements = ListComparator.Compare(intsArray, intsArray);

            // Assert
            numberOfSameElements.Should().Be(result);
        }

        [Fact]
        public void Should_ReturnNumberOfSameElements_For2Arrays()
        {
            // Arrange
            var subject = new[] { 1, 2, 3, 4, 5 };
            var reference = new[] { 1, 2, 3 };

            // Act
            var numberOfSameElements = ListComparator.Compare(subject, reference);

            // Assert
            numberOfSameElements.Should().Be(3);
        }

        [Fact]
        public void Should_Return0_For2DifferentArrays()
        {
            // Arrange
            var subject = new[] { 1, 2, 3, 4, 5 };
            var reference = new[] { 6, 7, 8, 9, 10 };

            // Act
            var numberOfSameElements = ListComparator.Compare(subject, reference);

            // Assert
            numberOfSameElements.Should().Be(0);
        }
    }
}