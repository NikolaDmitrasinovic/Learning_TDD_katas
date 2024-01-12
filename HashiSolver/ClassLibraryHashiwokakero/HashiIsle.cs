
namespace ClassLibraryHashiwokakero
{
    public class HashiIsle(int value, int x, int y)
    {
        public int Value { get; } = value;
        public List<HashiIsle> ConnectedIsles { get; private set; } = [];
        public object X { get; } = x;
        public object Y { get; } = y;

        public HashiBridge Connect(HashiIsle isle)
        {
            ConnectedIsles.Add(isle);
            return new HashiBridge(this, isle);
        }
    }
}
