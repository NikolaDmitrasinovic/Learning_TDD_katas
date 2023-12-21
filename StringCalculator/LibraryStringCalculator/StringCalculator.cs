namespace LibraryStringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbersString)
        {
            if (string.IsNullOrEmpty(numbersString))
                return 0;

            char delimiter = ',';

            if (numbersString.StartsWith("//"))
                delimiter = numbersString[2];

            string[] numbers = numbersString.Split(delimiter, '\n');

            return numbers.Sum(s => int.TryParse(s, out int n) ? n : 0);
        }
    }
}