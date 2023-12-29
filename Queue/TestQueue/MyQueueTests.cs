namespace TestQueue
{
    public class MyQueueTests
    {
        [Fact]
        public void Should_AddElementToQueue()
        {
            // Arrange
            var myQueue = new MyQueue<int>();

            // Act
            myQueue.Enqueue(1);

            // Assert
            myQueue.Count.Should().Be(1);
        }

        [Fact]
        public void Should_AddSomeElementsToQueue()
        {
            // Arrange
            var myQueue = new MyQueue<int>();

            // Act
            for (int i = 0; i < 10; i++)
            {
                myQueue.Enqueue(i);
            }

            // Assert
            myQueue.Count.Should().Be(10);
        }
    }
}
