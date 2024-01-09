namespace TestTree
{
    public class BinaryTreeTests
    {
        [Fact]
        public void Insert_AddsNodeToTree()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            tree.Insert(10);

            // Assert
            tree.Contains(10).Should().BeTrue();
        }

        [Fact]
        public void Insert_NumberSmallerThanRootValue_ShouldSetNodeLeft()
        {
            // Arrange
            var tree = new BinaryTree();

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
            var tree = new BinaryTree();

            // Act
            tree.Insert(10);
            tree.Insert(15);

            // Assert
            tree.Root.Right.Value.Should().Be(15);
        }

        [Fact]
        public void Contains_ReturnsFalseForNonexistentValue()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            tree.Insert(10);

            // Assert
            tree.Contains(11).Should().BeFalse();
        }

        [Fact]
        public void Contains_ReturnsFalseForNullNode()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            var nodeExists = tree.Contains(1);

            // Assert
            nodeExists.Should().BeFalse();
        }

        [Fact]
        public void Contains_ReturnsFindsValueFromAList()
        {
            // Arrange
            var tree = new BinaryTree();
            var unsortedList = new[] { 16, 1, 8, 3, 14, 9, 10 };

            // Act
            for (int i = 0; i < unsortedList.Length; i++)
            {
                tree.Insert(unsortedList[i]);
            }

            // Assert
            tree.Contains(8).Should().BeTrue();
        }
    }
}