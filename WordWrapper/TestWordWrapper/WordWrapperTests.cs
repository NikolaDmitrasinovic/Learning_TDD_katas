namespace TestWordWrapper
{
    public class WordWrapperTests
    {
        [Theory]
        [InlineData("", 0 , "")]
        [InlineData("text", 0 , "text")]
        [InlineData("line1 line2", 5 , "line1\nline2")]
        [InlineData("abcabcabc   ", 3 , "abc\nabc\nabc\n")]
        public void Should_FormatText_ToFitColumnlength(string input, int column, string result)
        {
            // Arrange

            // Act
            var wrappedText = WordWrapper.Wrap(input, column);

            // Assert
            wrappedText.Should().Be(result);
        }

        [Fact]
        public void Should_TryNotToBreakWords()
        {
            // Arrange

            // Act
            var wrappedText = WordWrapper.Wrap("don't break words", 7);

            // Assert
            wrappedText.Should().Be("don't \nbreak \nwords");
        }
    }
}