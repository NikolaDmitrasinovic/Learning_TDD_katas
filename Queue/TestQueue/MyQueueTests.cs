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
    }
}
