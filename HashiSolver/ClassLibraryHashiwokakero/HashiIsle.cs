
namespace ClassLibraryHashiwokakero
{
    public class HashiIsle(int value, int x, int y)
    {
        public int Value { get; } = value;
        public List<HashiIsle> ConnectedIsles { get; private set; } = [];
        public int X { get; } = x;
        public int Y { get; } = y;

        public HashiBridge Connect(HashiIsle isle)
        {
            ConnectedIsles.Add(isle);
            return new HashiBridge(this, isle);
        }
    }
}
