namespace ClassLibraryHashiwokakero
{
    public class HashiBridge
    {
        public HashiIsle IsleFrom { get; }
        public HashiIsle IsleTo { get; }
        public BridgeOrientation Orientation { get; }

        public HashiBridge(HashiIsle isle1, HashiIsle isle2)
        {
            if (isle1.Equals(isle2))
                throw new InvalidOperationException("Bridges can only connect distinct islands");

            if (IsHorizontal(isle1, isle2))
            {
                Orientation = BridgeOrientation.Horizontal;
                IsleFrom = isle1.X < isle2.X ? isle1 : isle2;
                IsleTo = isle1.X > isle2.X ? isle1 : isle2;
            }
            else if (IsVertical(isle1, isle2))
            {
                Orientation = BridgeOrientation.Vertical;
                IsleFrom = isle1.Y < isle2.Y ? isle1 : isle2;
                IsleTo = isle1.Y > isle2.Y ? isle1 : isle2;
            }
            else
                throw new InvalidOperationException("Only orthagonal bridges allowed.");
        }

        private static bool IsHorizontal(HashiIsle isle1, HashiIsle isle2)
        {
            return isle1.Y == isle2.Y;
        }

        private static bool IsVertical(HashiIsle isle1, HashiIsle isle2)
        {
            return isle1.X == isle2.X;
        }
    }

    public enum BridgeOrientation
    {
        Horizontal,
        Vertical
    }
}