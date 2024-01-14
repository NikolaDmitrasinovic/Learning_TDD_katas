namespace TestHashiwokakero
{
    public class HashiBridgeTests
    {
        [Fact]
        public static void Should_InitializeBridgeCorrectly()
        {
            // Arrange
            var isle1 = new HashiIsle(1, 1, 1);
            var isle2 = new HashiIsle(2, 1, 1);

            // Act
            var bridge = new HashiBridge(isle1, isle2);

            // Assert
            bridge.Isle1.Should().Be(isle1);
            bridge.Isle2.Should().Be(isle2);
        }
    }
}
