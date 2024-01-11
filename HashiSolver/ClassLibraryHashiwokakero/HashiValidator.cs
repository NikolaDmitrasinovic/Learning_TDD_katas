
namespace ClassLibraryHashiwokakero
{
    public class HashiValidator
    {
        public static bool Validate(HashiPuzzle puzzle)
        {
            if (puzzle.IsleList.Count == 0) 
                return false;

            for (int i = 0; i < puzzle.IsleList.Count; i++)
            {
                if (puzzle.IsleList[i].Value != puzzle.IsleList[i].ConnectedIsles.Count)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
