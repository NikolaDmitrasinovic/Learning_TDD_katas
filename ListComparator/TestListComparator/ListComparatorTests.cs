namespace TestListComparator
{
    public class ListComparatorTests
    {
        [Fact]
        public void Should_Return1_For1ElementArrayComparedtoItself()
        {
            // Arrange
            var intsArray = new[] { 1 };

            // Act
            var numberOfSameElements = ListComparator.Compare(intsArray, intsArray);

            // Assert
            numberOfSameElements.Should().Be(1);
        }

        [Fact]
        public void Should_Return2_For2ElementsArrayComparedtoItself()
        {
            // Arrange
            var intsArray = new[] { 1, 2 };

            // Act
            var numberOfSameElements = ListComparator.Compare(intsArray, intsArray);

            // Assert
            numberOfSameElements.Should().Be(2);
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
    }
}