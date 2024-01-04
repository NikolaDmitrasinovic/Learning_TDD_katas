namespace TestStack
{
    public class MyStackTests
    {
        [Fact]
        public void Should_AddElement()
        {
            // Arrange
            var myStack = new MyStack();

            // Act
            myStack.Push(1);

            // Assert
            myStack.Count.Should().Be(1);
        }

        [Fact]
        public void Should_ReturnLastElement()
        {
            // Arrange
            var myStack = new MyStack();

            // Act
            myStack.Push(5);
            myStack.Push(6);

            // Assert
            myStack.Pop().Should().Be(6);
            myStack.Count.Should().Be(1);
        }
    }
}