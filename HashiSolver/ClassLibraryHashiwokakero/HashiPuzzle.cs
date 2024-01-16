namespace ClassLibraryHashiwokakero
{
    public class HashiPuzzle
    {
        public List<HashiIsle> Isles { get; set; } = [];
        public List<HashiBridge> Bridges { get; set; } = [];

        public void AddBridge(int v1, int v2)
        {
            Bridges.Add(new HashiBridge(Isles[v1], Isles[v2]));
            Isles[v1].Connect(Isles[v2]);
            Isles[v2].Connect(Isles[v1]);
        }

        public void AddIsle(int value, int x, int y)
        {
            if (Isles.SingleOrDefault(i => i.X.Equals(x) && i.Y.Equals(y)) == null)
                Isles.Add(new HashiIsle(value, x, y));
            else
                throw new InvalidDataException("Isle already in the list");
        }
    }
}