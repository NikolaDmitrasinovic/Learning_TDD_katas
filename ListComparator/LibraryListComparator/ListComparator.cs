namespace LibraryListComparator
{
    public class ListComparator
    {
        public static int Compare(int[] intsArray1, int[] intsArray2)
        {
            if (intsArray1 != intsArray2)
            {
                int numberOfSameElements = 0;

                for (int i = 0; i < intsArray1.Length; i++)
                {
                    for (int n = 0; n < intsArray2.Length; n++)
                    {
                        if (intsArray1[i] == intsArray2[n])
                        {
                            numberOfSameElements++;
                        }
                    }
                }

                return numberOfSameElements;
            }

            return intsArray1.Length;
        }
    }
}