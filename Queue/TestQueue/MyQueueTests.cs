namespace TestQueue
{
    public class MyQueueTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        public void Should_AddElementsToQueue(int numberOfElements)
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
    }
}
