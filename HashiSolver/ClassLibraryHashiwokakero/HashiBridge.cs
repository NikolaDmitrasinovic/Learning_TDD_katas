namespace ClassLibraryHashiwokakero
{
    public class HashiBridge
    {
        public HashiIsle IsleFrom { get; }
        public HashiIsle IsleTo { get; }
        public BridgeOrientation Orientation { get; }

        public HashiBridge(HashiIsle isle1, HashiIsle isle2)
        {
            if (isle1.X == isle2.X)
            {
                Orientation = BridgeOrientation.Horizontal;
                IsleFrom = isle1.Y < isle2.Y ? isle1 : isle2;
                IsleTo = isle1.Y > isle2.Y ? isle1 : isle2;
            }
            else if (isle1.Y == isle2.Y)
            {                
                Orientation = BridgeOrientation.Vertical;
                IsleFrom = isle1.X < isle2.X ? isle1 : isle2;
                IsleTo = isle1.X > isle2.X ? isle1 : isle2;
            }        
        }
    }

    public enum BridgeOrientation
    {
        Horizontal,
        Vertical
    }
}