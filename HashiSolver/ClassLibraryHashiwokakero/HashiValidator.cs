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
            else if (HasMoreThanTwoBrigesBetweenIsles(puzzle))
                return false;

            return true;
        }

        private static bool HasMoreThanTwoBrigesBetweenIsles(HashiPuzzle puzzle)
        {
            foreach (var bridge in puzzle.Bridges)
            {
                if (puzzle.Bridges.Count(b => b.Equals(bridge)) > 2)
                    return true;
            }

            return false;
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

        private static bool HasBridgesCrossingIsles(HashiPuzzle puzzle)
        {
            foreach (var bridge in puzzle.Bridges)
            {
                if (IsIsleUnderBridge(bridge, puzzle.Isles))
                    return true;
            }

            return false;
        }

        private static bool IsIsleUnderBridge(HashiBridge bridge, List<HashiIsle> isles)
        {
            List<HashiIsle> horizontal = isles.Where(isle => isle.Y == bridge.IsleTo.Y).ToList();
            List<HashiIsle> vertical = isles.Where(isle => isle.X == bridge.IsleTo.X).ToList();

            return horizontal.Any(isle => IsInBetween(bridge.IsleFrom.X, isle.X, bridge.IsleTo.X)) 
                || vertical.Any(isle => IsInBetween(bridge.IsleFrom.Y, isle.Y, bridge.IsleTo.Y));
        }

        private static bool IsInBetween(int bridgeFrom, int isle, int bridgeTo)
        {
            return isle > bridgeFrom && isle < bridgeTo;
        }
    }
}
