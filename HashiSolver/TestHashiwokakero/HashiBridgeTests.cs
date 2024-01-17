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

        [Fact]
        public static void Initialize_DecideBridgeOrientation()
        {
            // Arrange
            var isle1 = new HashiIsle(1, 1, 1);
            var isle2 = new HashiIsle(2, 1, 1);

            // Act
            var bridge = new HashiBridge(isle1, isle2);

            // Assert
            bridge.Orientation.Should().Be(BridgeOrientation.Horizontal);
        }
    }
}
