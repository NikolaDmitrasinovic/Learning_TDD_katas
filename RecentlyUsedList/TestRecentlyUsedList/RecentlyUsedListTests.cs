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
    }
}