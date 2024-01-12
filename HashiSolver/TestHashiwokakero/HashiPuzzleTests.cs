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
            puzzle.AddIsle(1, 0, 0);
            puzzle.AddIsle(1, 0, 1);
            puzzle.AddIsle(2, 1, 0);
            puzzle.AddIsle(2, 1, 1);
            puzzle.AddBridge(0, 2);
            puzzle.AddBridge(1, 3);
            puzzle.AddBridge(2, 3);

            // Assert
            puzzle.Isles.Count.Should().Be(4);
            puzzle.BridgeList.Count.Should().Be(3);
        }

        [Fact]
        public static void Should_AddConnectionToIslesWhenAddingBridge()
        {
            // Arrange
            var puzzle = new HashiPuzzle();

            // Act
            puzzle.AddIsle(1, 0, 0);
            puzzle.AddIsle(1, 0, 1);
            puzzle.AddBridge(0, 1);

            // Assert
            puzzle.Isles[0].ConnectedIsles.Count.Should().Be(1);
            puzzle.Isles[1].ConnectedIsles.Count.Should().Be(1);
        }

        [Fact]
        public static void AddIsle_ReturnsException_IfIsleAlreadyInTheList()
        {
            // Arrange
            var puzzle = new HashiPuzzle();

            // Act
            puzzle.AddIsle(5, 1, 1);

            // Assert
            puzzle.Invoking(x => puzzle.AddIsle(8, 1, 1))
                .Should()
                .Throw<InvalidDataException>()
                .WithMessage("Isle already in the list");
        }
    }
}
