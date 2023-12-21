namespace LibraryStringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbersString)
        {
            char[] delimiter = ReturnDelimiter(numbersString);

            IEnumerable<int> numbers = numbersString.Split(delimiter).Select(s => int.TryParse(s, out int n) ? n : 0);

            IEnumerable<int> negativeNumbers = numbers.Where(negative => negative < 0);
            if (negativeNumbers.Any())
            {
                throw new ArgumentException("negatives not allowed (" + string.Join(")(", negativeNumbers) + ")");
            }

            return numbers.Sum();
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