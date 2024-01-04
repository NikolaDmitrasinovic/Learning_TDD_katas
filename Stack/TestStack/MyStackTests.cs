namespace TestStack
{
    public class MyStackTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public void Should_AddElement(int noOfElements)
        {
            // Arrange
            var myStack = new MyStack();

            // Act
            for (int i = 0; i < noOfElements; i++)
            {
                myStack.Push(i);
            }

            // Assert
            myStack.Count.Should().Be(noOfElements);
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

        [Fact]
        public void Should_ShowLastElement()
        {
            // Arrange
            var myStack = new MyStack();

            // Act
            myStack.Push(5);
            myStack.Push(6);

            // Assert
            myStack.Peek().Should().Be(6);
            myStack.Count.Should().Be(2);
        }
    }
}