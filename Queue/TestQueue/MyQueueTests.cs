namespace TestQueue
{
    public class MyQueueTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        public void Should_AddElements(int numberOfElements)
        {
            // Arrange
            var myQueue = new MyQueue<int>();

            // Act
            for (int i = 0; i < numberOfElements; i++)
            {
                myQueue.Enqueue(i);
            }

            // Assert
            myQueue.Count.Should().Be(numberOfElements);
        }

        [Fact]
        public void Should_ReturnFirstElement()
        {
            // Arrange
            var myQueue = new MyQueue<string>();

            // Act
            myQueue.Enqueue("first element");
            myQueue.Enqueue("last element");
            var lastElement = myQueue.Peek();

            // Assert
            lastElement.Should().Be("first element");
            myQueue.Count.Should().Be(2);
        }

        [Fact]
        public void Should_ReturnFirstlement_AndRemoveItFromTheQueue()
        {
            // Arrange
            var myQueue = new MyQueue<double>();

            // Act
            myQueue.Enqueue(2.5);
            myQueue.Enqueue(5.2);
            var lastElement = myQueue.Dequeue();

            // Assert
            lastElement.Should().Be(2.5);
            myQueue.Count.Should().Be(1);
        }

        [Fact]
        public void Should_ThrowException_ForDequeueCallOnEmptyQueue()
        {
            // Arrange
            var myQueue = new MyQueue<double>();

            // Act

            // Assert
            myQueue.Invoking(x => myQueue.Dequeue())
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Can not execute on empty queue");
        }
    }
}
