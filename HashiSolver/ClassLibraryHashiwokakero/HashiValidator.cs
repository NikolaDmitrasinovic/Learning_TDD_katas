
namespace ClassLibraryHashiwokakero
{
    public class HashiValidator
    {
        public static bool Validate(HashiPuzzle puzzle)
        {
            if (!HasNeededAmountOfBrigdes(puzzle))
                return false;
            else if (HasDiagonalBridges(puzzle))
                return false;
            else if (HasBridgesCross(puzzle))
                return false;

            return true;
        }

        private static bool HasBridgesCross(HashiPuzzle puzzle)
        {
            foreach (var bridge1 in puzzle.Bridges)
            {
                foreach (var bridge2 in puzzle.Bridges)
                {
                    if (!bridge1.Equals(bridge2))
                        continue;

                    if (AreCrossing(bridge1, bridge2))
                        return true;
                }
            }

            return false;
        }

        private static bool HasDiagonalBridges(HashiPuzzle puzzle)
        {
            foreach (var bridge in puzzle.Bridges)
            {
                if (bridge.Isle1.X != bridge.Isle2.X && bridge.Isle1.Y != bridge.Isle2.Y)
                    return true;
            }

            return false;
        }

        private static bool AreCrossing(HashiBridge bridge1, HashiBridge bridge2)
        {
            if (bridge1.Isle1.X == bridge1.Isle2.X && bridge2.Isle1.Y == bridge2.Isle2.Y)
            {
                if (bridge1.Isle1.Y < bridge2.Isle1.Y && bridge1.Isle2.Y > bridge2.Isle1.Y)
                {
                    return true;
                }
            }

            if (bridge1.Isle1.Y == bridge1.Isle2.Y && bridge2.Isle1.X == bridge2.Isle2.X)
            {
                if (bridge1.Isle1.X < bridge2.Isle1.X && bridge1.Isle2.X > bridge2.Isle1.X)
                {
                    return true;
                }
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
    }
}
