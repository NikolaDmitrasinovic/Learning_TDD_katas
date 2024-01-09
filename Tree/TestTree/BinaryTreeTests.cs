namespace TestTree
{
    public class BinaryTreeTests
    {
        private readonly BinaryTree tree;

        public BinaryTreeTests()
        {
            tree = new BinaryTree();
        }

        private static void PopulateTree(BinaryTree tree, int[] unsortedList)
        {
            for (int i = 0; i < unsortedList.Length; i++)
            {
                tree.Insert(unsortedList[i]);
            }
        }

        [Fact]
        public void Insert_AddsNodeToTree()
        {
            // Arrange

            // Act
            tree.Insert(10);

            // Assert
            tree.Root.Should().NotBeNull();
        }

        [Fact]
        public void Insert_NumberSmallerThanRootValue_ShouldSetNodeLeft()
        {
            // Arrange

            // Act
            tree.Insert(10);
            tree.Insert(5);

            // Assert
            tree.Root.Left.Value.Should().Be(5);
        }

        [Fact]
        public void Insert_NumberGreaterThanRootValue_ShouldSetNodeRight()
        {
            // Arrange

            // Act
            tree.Insert(10);
            tree.Insert(15);

            // Assert
            tree.Root.Right.Value.Should().Be(15);
        }

        [Fact]
        public void Contains_ReturnsFalseForNullNode()
        {
            // Arrange

            // Act

            // Assert
            tree.Contains(1).Should().BeFalse();
        }

        [Fact]
        public void Contains_ReturnsFalseForNonexistentValue()
        {
            // Arrange

            // Act
            tree.Insert(10);

            // Assert
            tree.Contains(11).Should().BeFalse();
        }

        [Theory]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 16, 4, 8, 6, 12 },8)]
        public void Contains_ReturnsFindsValueFromAList(int[] ints, int value)
        {
            // Arrange

            // Act
            PopulateTree(tree, ints);

            // Assert
            tree.Contains(value).Should().BeTrue();
        }

        [Fact]
        public void ReturnTree_ReturnsSortedList()
        {
            // Arrange
            var unsortedList = new[] { 16, 4, 8, 6, 12 };
            var sortedList = new List<int>();

            PopulateTree(tree, unsortedList);

            // Act
            BinaryTree.ReturnTree(tree.Root, sortedList);

            // Assert
            sortedList.Should().BeInAscendingOrder();
        }
    }
}