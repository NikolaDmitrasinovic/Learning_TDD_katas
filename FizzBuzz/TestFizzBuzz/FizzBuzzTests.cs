namespace TestFizzBuzz
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Should_Return1_For1Iteration()
        {
            // Arrange

            // Act
            var gameResult = FizzBuzz.Play(1);

            // Assert
            gameResult.Should().BeEquivalentTo(["1"]);
        }
    }
}