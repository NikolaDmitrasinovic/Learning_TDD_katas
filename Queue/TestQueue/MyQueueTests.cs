namespace TestQueue
{
    public class MyQueueTests
    {
        [Fact]
        public void Should_AddElementToQueue()
        {
            // Arrange
            var myQueue = new MyQueue();

            // Act
            myQueue.Enqueue();

            // Assert
            myQueue.Count.Should().Be(1);
        }
    }
}
