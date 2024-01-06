namespace TestRecentlyUsedList
{
    public class RecentlyUsedListTests
    {
        private static void FillList(int numberOfItems, RecentlyUsedList recentlyUsedList)
        {
            for (int i = 0; i < numberOfItems; i++)
            {
                recentlyUsedList.AddRecentItem("item" + i);
            }
        }

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
            FillList(numberOfItems, recentlyUsedList);

            // Assert
            recentlyUsedList.NumberOfRecentItems.Should().Be(numberOfItems);
        }

        [Fact]
        public void Should_KeepUpTo10Items_ForNoNumberPassedToCtor()
        {
            // Arrange
            var recentlyUsedList = new RecentlyUsedList();

            // Act
            FillList(15, recentlyUsedList);

            // Assert
            recentlyUsedList.NumberOfRecentItems.Should().Be(10);
        }

        [Theory]
        [InlineData(0, "item7")]
        [InlineData(7, "item0")]
        public void Should_ReturnRecentItem_ForIndexNumberCountingFromZero(int index, string item)
        {
            // Arrange
            var recentlyUsedList = new RecentlyUsedList();

            // Act
            FillList(8, recentlyUsedList);

            // Assert
            recentlyUsedList.ReturnRecentItem(index).Should().Be(item);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        public void Should_ThrowException_ForIndexOutOfRange(int index)
        {
            // Arrange
            var recentlyUsedList = new RecentlyUsedList();

            // Act

            // Assert
            recentlyUsedList.Invoking(x => recentlyUsedList.ReturnRecentItem(index))
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
            recentlyUsedList.ReturnRecentItem(0).Should().Be("newer item");
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
            recentlyUsedList.ReturnRecentItem(0).Should().Be("first item");
        }
    }
}