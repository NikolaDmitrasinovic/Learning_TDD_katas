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
        public void Should_PlayFizzBuzz_ForSetNumberOfIterations(int iterations, string[] result)
        {
            // Arrange

            // Act
            var gameResult = FizzBuzz.Play(iterations);

            // Assert
            gameResult.Should().BeEquivalentTo(result);
        }

        [Theory]
        [InlineData(100, 14, 89, "FizzBuzz")]
        [InlineData(100, 2, 98, "Fizz")]
        [InlineData(100, 4, 99, "Buzz")]
        public void Should_ReturnFizzBuzz_ForSetNumberOfIterations(int iterations, int firstOccurence, int lastOccurence, string result)
        {
            // Arrange

            // Act
            var gameResult = FizzBuzz.Play(iterations);

            // Assert
            gameResult.Should().HaveElementAt(firstOccurence, result)
                .And.HaveElementAt(lastOccurence, result);
        }
    }
}