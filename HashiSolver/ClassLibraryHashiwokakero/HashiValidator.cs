namespace ClassLibraryHashiwokakero
{
    public class HashiValidator
    {
        public static bool Validate(HashiPuzzle puzzle)
        {
            if (!HasNeededAmountOfBrigdes(puzzle))
                return false;
            else if (HasBridgesCross(puzzle))
                return false;
            else if (HasBridgesCrossingIsles(puzzle))
                return false;

            return true;
        }

        private static bool HasNeededAmountOfBrigdes(HashiPuzzle puzzle)
        {
            foreach (var isle in puzzle.Isles)
                if (isle.ConnectedIsles.Count != isle.Value)
                    return false;

            return true;
        }

        private static bool HasBridgesCross(HashiPuzzle puzzle)
        {
            List<HashiBridge> horizontalBridges = puzzle.Bridges.Where(b => b.Orientation == BridgeOrientation.Horizontal).ToList();
            List<HashiBridge> verticalBridges = puzzle.Bridges.Where(b => b.Orientation == BridgeOrientation.Vertical).ToList();

            foreach (var bridgeH in horizontalBridges)
            {
                foreach (var bridgeV in verticalBridges)
                {
                    if (AreCrossing(bridgeH, bridgeV))
                        return true;
                }
            }

            return false;
        }

        private static bool AreCrossing(HashiBridge bridgeH, HashiBridge bridgeV)
        {
            if (bridgeH.IsleFrom.X < bridgeV.IsleTo.X && bridgeH.IsleTo.X > bridgeV.IsleTo.X)
                return true;

            return false;
        }

        // TODO refactor 
        private static bool HasBridgesCrossingIsles(HashiPuzzle puzzle)
        {
            foreach (var bridge in puzzle.Bridges)
            {
                foreach (var isle in puzzle.Isles)
                {
                    if (isle.Y == bridge.IsleTo.Y && isle.X > bridge.IsleFrom.X && isle.X < bridge.IsleTo.X)
                        return true;

                    if (isle.X == bridge.IsleFrom.X && isle.Y > bridge.IsleFrom.Y && isle.Y < bridge.IsleTo.Y)
                        return true;
                }
            }

            return false;
        }        
    }
}
