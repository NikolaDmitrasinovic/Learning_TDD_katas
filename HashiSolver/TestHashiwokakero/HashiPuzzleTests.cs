namespace TestHashiwokakero
{
    public class HashiPuzzleTests
    {
        [Fact]
        public static void Should_CreateSmallestPossiblePuzzle()
        {
            // Arrange
            var puzzle = new HashiPuzzle();

            // Act
            puzzle.AddIsle(1);
            puzzle.AddIsle(1);
            puzzle.AddIsle(2);
            puzzle.AddIsle(2);
            puzzle.AddBridge(0, 2);
            puzzle.AddBridge(1, 3);
            puzzle.AddBridge(2, 3);

            // Assert
            puzzle.IsleList.Count.Should().Be(4);
            puzzle.BridgeList.Count.Should().Be(3);
        }
    }
}
