namespace TestFizzBuzz
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act
            var gameResult = FizzBuzz.Play(1);

            // Assert
            gameResult.Should().BeEquivalentTo(["1"]);
        }
    }
}