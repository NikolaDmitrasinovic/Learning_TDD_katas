namespace ClassLibraryHashiwokakero
{
    public class HashiBridge
    {
        public HashiIsle IsleFrom { get; }
        public HashiIsle IsleTo { get; }
        public BridgeOrientation Orientation { get; }

        private HashiBridge(HashiIsle isle1, HashiIsle isle2, BridgeOrientation orientation)
        {
            IsleFrom = isle1;
            IsleTo = isle2;
            Orientation = orientation;
        }

        public class HashiBridgeBuilder
        {
            private HashiIsle? _isle1;
            private HashiIsle? _isle2;

            public HashiBridgeBuilder Isle1(HashiIsle isle1)
            {
                _isle1 = isle1;
                return this;
            }

            public HashiBridgeBuilder Isle2(HashiIsle isle2)
            {
                _isle2 = isle2;
                return this;
            }

            public HashiBridge Build()
            {
                if (_isle1 == null || _isle2 == null || _isle1.Equals(_isle2))
                    throw new InvalidOperationException("Invalid bridge configuration");

                HashiIsle isleFrom;
                HashiIsle isleTo;
                BridgeOrientation orientation;

                if (IsHorizontal(_isle1, _isle2))
                {
                    orientation = BridgeOrientation.Horizontal;
                    isleFrom = _isle1.X < _isle2.X ? _isle1 : _isle2;
                    isleTo = _isle1.X > _isle2.X ? _isle1 : _isle2;
                }
                else if (IsVertical(_isle1, _isle2))
                {
                    orientation = BridgeOrientation.Vertical;
                    isleFrom = _isle1.Y < _isle2.Y ? _isle1 : _isle2;
                    isleTo = _isle1.Y > _isle2.Y ? _isle1 : _isle2;
                }
                else
                    throw new InvalidOperationException("Only orthagonal bridges allowed");

                return new HashiBridge(isleFrom, isleTo, orientation);
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

        public override bool Equals(object? obj)
        {
            HashiBridge otherBridge = obj as HashiBridge ?? throw new NullReferenceException();
            if(IsleFrom.Equals(otherBridge.IsleFrom) && IsleTo.Equals(otherBridge.IsleTo))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public enum BridgeOrientation
    {
        Horizontal,
        Vertical
    }
}