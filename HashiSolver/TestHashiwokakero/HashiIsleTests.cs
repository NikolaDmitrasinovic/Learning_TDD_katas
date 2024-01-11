namespace TestHashiwokakero
{
    public class HashiIsleTests
    {
        [Fact]
        public static void ConnectIsle_AddsIsleToConnectedIsleList()
        {
            // Arrange
            var isle1 = new HashiIsle(2);
            var isle2 = new HashiIsle(1);

            // Act
            var bridge = isle1.Connect(isle2);

            // Assert
            isle1.ConnectedIsles.Count.Should().Be(1);
            isle1.ConnectedIsles[0].Should().Be(isle2);
            bridge.Should().NotBeNull();
        }
    }
}
