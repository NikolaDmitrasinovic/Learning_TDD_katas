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

        [Fact]
        public void Should_BreakeSimpleText()
        {
            // Arrange

            // Act
            var wrappedText = WordWrapper.Wrap("ab", 1);

            // Assert
            wrappedText.Should().Be("a\nb");
        }

        [Fact]
        public void Should_InsertLineBreakes_ForColumnNumber()
        {
            // Arrange

            // Act
            var wrappedText = WordWrapper.Wrap("abcabcabc", 3);

            // Assert
            wrappedText.Should().Be("abc\nabc\nabc");
        }
    }
}