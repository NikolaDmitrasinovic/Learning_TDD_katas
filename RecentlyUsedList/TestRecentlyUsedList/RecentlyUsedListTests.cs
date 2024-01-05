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
    }
}