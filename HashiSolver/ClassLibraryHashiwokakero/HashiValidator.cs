namespace ClassLibraryHashiwokakero
{
    public class HashiValidator
    {
        public static bool Validate(HashiPuzzle puzzle)
        {
            if (IsNotReady(puzzle))
                return false;
            else if (IsNotBridgeCovered(puzzle))
                return false;

            return true;
        }

        private static bool IsNotReady(HashiPuzzle puzzle)
        {
            if (puzzle.Isles.Count == 0)
                return true;

            return false;
        }

        private static bool IsNotBridgeCovered(HashiPuzzle puzzle)
        {
            foreach (var isle in puzzle.Isles)
                if (isle.ConnectedIsles.Count != isle.Value)
                    return true;

            return false;
        }
    }
}
