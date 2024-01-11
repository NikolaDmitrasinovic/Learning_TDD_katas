
namespace ClassLibraryHashiwokakero
{
    public class HashiIsle(int value)
    {
        public int Value { get; } = value;
        public List<HashiIsle> ConnectedIsles { get; private set; } = [];

        public HashiBridge Connect(HashiIsle isle)
        {
            ConnectedIsles.Add(isle);
            return new HashiBridge(this, isle);
        }
    }
}
