namespace LibraryPrimeFactor
{
    public class PrimeFactor
    {
        public static List<int> Generate(int number)
        {
            List<int> primeFactors = [];

            for (int candidate = 2; number > 1; candidate++)
                for (; number % candidate == 0; number /= candidate)
                    primeFactors.Add(candidate);

            return primeFactors;
        }
    }
}