namespace LibraryListComparator
{
    public class ListComparator
    {
        public static int Compare(int[] subject, int[] reference)
        {
            return subject.Intersect(reference).Count();
        }
    }
}