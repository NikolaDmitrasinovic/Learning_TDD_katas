namespace LibraryListComparator
{
    public class ListComparator
    {
        public static int Compare(int[] intsArray1, int[] intsArray2)
        {
            if (intsArray1.Length > 1)
            {
                return intsArray1.Length;
            }

            return 1;
        }
    }
}