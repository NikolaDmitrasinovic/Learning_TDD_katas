namespace LibraryPrimeFactor
{
    public class PrimeFactor
    {
        public static List<int> Generate(int number)
        {
            List<int> primeFactors = [];

            while(number >= 2)
            {
                number /= 2;
                primeFactors.Add(2);
            }

            return primeFactors;
        }
    }
}