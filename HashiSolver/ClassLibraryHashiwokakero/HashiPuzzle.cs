
namespace ClassLibraryHashiwokakero
{
    public class HashiPuzzle
    {
        public List<HashiIsle> IsleList { get; set; } = new List<HashiIsle>();
        public List<HashiBridge> BridgeList { get; set; } = new List<HashiBridge>();

        public void AddBridge(int v1, int v2)
        {
            BridgeList.Add(new HashiBridge(IsleList[v1], IsleList[v2]));
        }

        public void AddIsle(int value)
        {
            IsleList.Add(new HashiIsle(value));
        }
    }
}