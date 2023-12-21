namespace LibraryStringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbersString)
        {
            char[] delimiter = ReturnDelimiter(numbersString);

            string[] numbers = numbersString.Split(delimiter);

            return numbers.Sum(s => int.TryParse(s, out int n) ? n : 0);
        }

        private static char[] ReturnDelimiter(string numbersString)
        {
            List<char> delimiter = ['\n', ','];

            if (numbersString.StartsWith("//"))
                delimiter.Add(numbersString[2]);

            return [.. delimiter];
        }
    }
}