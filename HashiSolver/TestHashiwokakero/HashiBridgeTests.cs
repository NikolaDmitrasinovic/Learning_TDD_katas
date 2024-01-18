using System.Collections.Generic;

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
            var bridge = new HashiBridge.HashiBridgeBuilder().Isle1(isle1).Isle2(isle2).Build();

            // Assert
            bridge.IsleFrom.Should().Be(isle1);
            bridge.IsleTo.Should().Be(isle2);
        }

        [Theory]
        [InlineData(1, 1, 1, 3, BridgeOrientation.Vertical)]
        [InlineData(3, 1, 5, 1, BridgeOrientation.Horizontal)]
        public static void Initialize_DecideBridgeOrientation(int isle1X, int isle1Y, int isle2X, int isle2Y, BridgeOrientation orientation)
        {
            // Arrange
            var isle1 = new HashiIsle(1, isle1X, isle1Y);
            var isle2 = new HashiIsle(2, isle2X, isle2Y);

            // Act
            var bridge = new HashiBridge.HashiBridgeBuilder().Isle1(isle1).Isle2(isle2).Build();

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
            var bridge = () => new HashiBridge.HashiBridgeBuilder().Isle1(isle1).Isle2(isle2).Build();

            // Assert
            bridge.Should().Throw<InvalidOperationException>().WithMessage("Only orthagonal bridges allowed");
        }

        [Fact]
        public static void Initialize_ReturnsExceptionForBridgeingIsleToItslef()
        {
            // Arrange
            var isle = new HashiIsle(1, 2, 2);

            // Act
            var bridge = () => new HashiBridge.HashiBridgeBuilder().Isle1(isle).Isle2(isle).Build();

            // Assert
            bridge.Should().Throw<InvalidOperationException>().WithMessage("Invalid bridge configuration");
        }

        [Fact]
        public static void Equals_ReturnsTrue_IfBridgesConnectSameIsles()
        {
            // Arrange
            var isle1 = new HashiIsle(1, 2, 2);
            var isle2 = new HashiIsle(1, 2, 1);

            // Act
            var bridge1 = new HashiBridge.HashiBridgeBuilder().Isle1(isle1).Isle2(isle2).Build();
            var bridge2 = new HashiBridge.HashiBridgeBuilder().Isle1(isle1).Isle2(isle2).Build();

            // Assert
            bridge1.Equals(bridge2).Should().BeTrue();
        }
    }
}
