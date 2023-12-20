namespace LibraryPrimeFactor
{
    public class PrimeFactor
    {
        public static List<int> Generate(int number)
        {
            if (number < 2)
                return [];

            return new List<int> { number };
        }
    }
}