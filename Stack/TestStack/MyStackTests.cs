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
    }
}