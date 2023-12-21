namespace LibraryStringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbersString)
        {
            if (string.IsNullOrEmpty(numbersString))
                return 0;

            string[] numbers = numbersString.Split(',', '\n');

            return numbers.Sum(n => int.Parse(n));
        }
    }
}