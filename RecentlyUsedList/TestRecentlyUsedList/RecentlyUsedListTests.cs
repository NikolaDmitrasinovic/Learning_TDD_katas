namespace TestRecentlyUsedList
{
    public class RecentlyUsedListTests
    {
        [Fact]
        public void Should_BeEmpty_AtInitialisation()
        {
            // Arrange
            var recentlyUsedList = new RecentlyUsedList();

            // Act

            // Assert
            recentlyUsedList.NumberOfRecentItems.Should().Be(0);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void Should_AddItems_ToTheList(int numberOfItems)
        {
            // Arrange
            var recentlyUsedList = new RecentlyUsedList();

            // Act
            for (int i = 0; i < numberOfItems; i++)
            {
                recentlyUsedList.AddRecentItem("item" + i);
            }            

            // Assert
            recentlyUsedList.NumberOfRecentItems.Should().Be(numberOfItems);
        }

        [Fact]
        public void Should_ReturnRecentItem_ForIndexNumberCountingFromZero()
        {
            // Arrange
            var recentlyUsedList = new RecentlyUsedList();

            // Act
            recentlyUsedList.AddRecentItem("item");

            // Assert
            recentlyUsedList.ReturnRecentItem(0).Should().Be("item");
        }

        [Fact]
        public void Should_ThrowException_ForIndexOutOfRange()
        {
            // Arrange
            var recentlyUsedList = new RecentlyUsedList();

            // Act

            // Assert
            recentlyUsedList.Invoking(x => recentlyUsedList.ReturnRecentItem(5))
                .Should()
                .Throw<IndexOutOfRangeException>()
                .WithMessage("List empty or index out of range");
        }

        [Fact]
        public void Should_AddMoreRecentItem_ToTheBeginningOfTheList()
        {
            // Arrange
            var recentlyUsedList = new RecentlyUsedList();

            // Act
            recentlyUsedList.AddRecentItem("item");
            recentlyUsedList.AddRecentItem("newer item");

            // Assert
            recentlyUsedList.NumberOfRecentItems.Should().Be(2);
            recentlyUsedList.RecentItems[0].Should().Be("newer item");
        }

        [Fact]
        public void Should_MoveDuplicateInsertionsToFront_RatherThanAddingThem()
        {
            // Arrange
            var recentlyUsedList = new RecentlyUsedList();

            // Act
            recentlyUsedList.AddRecentItem("first item");
            recentlyUsedList.AddRecentItem("second item");
            recentlyUsedList.AddRecentItem("first item");

            // Assert
            recentlyUsedList.NumberOfRecentItems.Should().Be(2);
            recentlyUsedList.RecentItems[0].Should().Be("first item");
        }
    }
}