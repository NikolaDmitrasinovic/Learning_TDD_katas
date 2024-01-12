
namespace ClassLibraryHashiwokakero
{
    public class HashiPuzzle
    {
        public List<HashiIsle> Isles { get; set; } = new List<HashiIsle>();
        public List<HashiBridge> BridgeList { get; set; } = new List<HashiBridge>();

        public void AddBridge(int v1, int v2)
        {
            BridgeList.Add(new HashiBridge(Isles[v1], Isles[v2]));
            Isles[v1].Connect(Isles[v2]);
            Isles[v2].Connect(Isles[v1]);
        }

        public void AddIsle(int value)
        {
            Isles.Add(new HashiIsle(value));
        }
    }
}