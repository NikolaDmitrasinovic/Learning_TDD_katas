namespace LibraryPrimeFactor
{
    public class PrimeFactor
    {
        public static List<int> Generate(int number)
        {
            if (number < 2)
                return [];

            var list = new List<int>();

            while(number >= 2)
            {
                number /= 2;
                list.Add(2);
            }

            return list;
        }
    }
}