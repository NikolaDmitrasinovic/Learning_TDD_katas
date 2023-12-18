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

        [Fact]
        public void Should_Return12_For2Iteration()
        {
            // Arrange

            // Act
            var gameResult = FizzBuzz.Play(2);

            // Assert
            gameResult.Should().BeEquivalentTo(["1", "2"]);
        }

        [Fact]
        public void Should_ReturnFizz_For3Multiplayer()
        {
            // Arrange

            // Act
            var gameResult = FizzBuzz.Play(3);

            // Assert
            gameResult.Should().BeEquivalentTo(["1", "2", "Fizz"]);
        }

        [Fact]
        public void Should_ReturnBuzz_For5Multiplayer()
        {
            // Arrange

            // Act
            var gameResult = FizzBuzz.Play(5);

            // Assert
            gameResult.Should().BeEquivalentTo(["1", "2", "Fizz", "4", "Buzz"]);
        }
    }
}