namespace TestFizzBuzz
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1, new string[] { "1" })]
        [InlineData(2, new string[] { "1", "2" })]
        [InlineData(3, new string[] { "1", "2", "Fizz" })]
        [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
        [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        public void Should_Return1_For1Iteration(int iterations, string[] result)
        {
            // Arrange

            // Act
            var gameResult = FizzBuzz.Play(iterations);

            // Assert
            gameResult.Should().BeEquivalentTo(result);
        }
    }
}