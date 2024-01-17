namespace TestHashiwokakero
{
    public class HashiIsleTests
    {
        [Fact]
        public static void Initialize_IsleCorrectly()
        {
            // Arrange
            var isle = new HashiIsle(2, 1, 1);

            // Act

            // Assert
            isle.Value.Should().Be(2);
            isle.ConnectedIsles.Count.Should().Be(0);
            isle.X.Should().Be(1);
            isle.Y.Should().Be(1);
        }

        [Fact]
        public static void ConnectIsle_AddsIsleToConnectedIsleList()
        {
            // Arrange
            var isle1 = new HashiIsle(2, 1, 1);
            var isle2 = new HashiIsle(1, 1, 1);

            // Act
            var bridge = isle1.Connect(isle2);

            // Assert
            isle1.ConnectedIsles.Count.Should().Be(1);
            isle1.ConnectedIsles[0].Should().Be(isle2);
            bridge.Should().NotBeNull();
        }
    }
}
