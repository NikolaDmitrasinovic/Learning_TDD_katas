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
            tree.Node.Left.Value.Should().Be(5);
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
    }
}