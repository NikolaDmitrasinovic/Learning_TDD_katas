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
        public void Contains_ReturnsFalseForNonexistentValue()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            tree.Insert(10);

            // Assert
            tree.Contains(11).Should().BeFalse();
        }
    }
}