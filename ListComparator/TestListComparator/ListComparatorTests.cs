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
    }
}