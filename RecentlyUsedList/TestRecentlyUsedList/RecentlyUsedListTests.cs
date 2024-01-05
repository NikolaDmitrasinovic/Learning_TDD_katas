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

        [Fact]
        public void Should_AddItem_ToTheList()
        {
            // Arrange
            var recentlyUsedList = new RecentlyUsedList();

            // Act
            recentlyUsedList.AddRecentItem("item1");

            // Assert
            recentlyUsedList.NumberOfRecentItems.Should().Be(1);
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