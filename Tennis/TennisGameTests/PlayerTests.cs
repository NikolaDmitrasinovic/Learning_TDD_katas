namespace TennisGameTests
{
    public class PlayerTests
    {
        [Fact]
        public void Should_TrackPlayerScore()
        {
            // Arrange
            var player = new Player();

            // Act
            player.PlayerScores();

            // Assert
            player.Score.Should().Be(1);
        }
    }
}
