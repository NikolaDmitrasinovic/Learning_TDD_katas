namespace LibraryPrimeFactor
{
    public class PrimeFactor
    {
        public static List<int> Generate(int number)
        {
            List<int> primeFactors = [];
            int prime = 2;

            while (number >= 2)
            {
                while (number % prime != 0)
                    prime++;

                number /= prime;
                primeFactors.Add(prime);
            }

            return primeFactors;
        }
    }
}