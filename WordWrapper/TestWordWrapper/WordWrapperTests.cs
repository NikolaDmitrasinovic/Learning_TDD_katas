namespace TestWordWrapper
{
    public class WordWrapperTests
    {
        [Fact]
        public void Should_ReturnOneLineString_ForNoSetColumn()
        {
            // Arrange

            // Act
            var wrappedText = WordWrapper.Wrap("one line text");

            // Assert
            wrappedText.Should().Be("one line text");
        }
    }
}