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
            tree.Root.Should().NotBeNull();
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
        public void Contains_ReturnsFalseForNullNode()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act

            // Assert
            tree.Contains(1).Should().BeFalse();
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

        [Theory]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 16, 4, 8, 6, 12 },8)]
        public void Contains_ReturnsFindsValueFromAList(int[] ints, int value)
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            for (int i = 0; i < ints.Length; i++)
            {
                tree.Insert(ints[i]);
            }

            // Assert
            tree.Contains(value).Should().BeTrue();
        }
    }
}