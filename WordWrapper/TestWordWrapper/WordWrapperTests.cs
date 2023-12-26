namespace TestWordWrapper
{
    public class WordWrapperTests
    {
        [Theory]
        [InlineData("", 0 , "")]
        [InlineData("text", 0 , "text")]
        [InlineData("line1 line2", 5 , "line1\nline2")]
        [InlineData("Long Text Wrap", 5 , "Long \nText \nWrap")]
        public void Should_FormatText_ToFitColumnlength(string input, int column, string result)
        {
            // Arrange

            // Act
            var wrappedText = WordWrapper.Wrap(input, column);

            // Assert
            wrappedText.Should().Be(result);
        }

        //[Fact]
        //public void Should_TryNotToBreakWords()
        //{
        //    // Arrange

        //    // Act
        //    var wrappedText = WordWrapper.Wrap("one word and another", 5);

        //    // Assert
        //    wrappedText.Should().Be("one \nword \nand \nanother");
        //}
    }
}