namespace TestHashiwokakero
{
    public class HashiBridgeTests
    {
        [Fact]
        public static void Initialize_CreateBridgeCorrectly()
        {
            // Arrange
            var isle1 = new HashiIsle(1, 1, 1);
            var isle2 = new HashiIsle(2, 1, 2);

            // Act
            var bridge = new HashiBridge(isle1, isle2);

            // Assert
            bridge.IsleFrom.Should().Be(isle1);
            bridge.IsleTo.Should().Be(isle2);
        }

        [Theory]
        [InlineData(1, 1, 1, 3, BridgeOrientation.Horizontal)]
        [InlineData(3, 1, 5, 1, BridgeOrientation.Vertical)]
        public static void Initialize_DecideBridgeOrientation(int isle1X, int isle1Y, int isle2X, int isle2Y, BridgeOrientation orientation)
        {
            // Arrange
            var isle1 = new HashiIsle(1, isle1X, isle1Y);
            var isle2 = new HashiIsle(2, isle2X, isle2Y);

            // Act
            var bridge = new HashiBridge(isle1, isle2);

            // Assert
            bridge.Orientation.Should().Be(orientation);
        }

        [Fact]
        public static void Initialize_ReturnsExceptionForDiagonalBridge()
        {
            // Arrange
            var isle1 = new HashiIsle(1, 2, 2);
            var isle2 = new HashiIsle(1, 1, 1);

            // Act
            var bridge = () => new HashiBridge(isle1, isle2);

            // Assert
            bridge.Should().Throw<InvalidOperationException>().WithMessage("Only orthagonal bridges allowed.");
        }
    }
}
