namespace LibraryStringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbersString)
        {
            char[] delimiter = ReturnDelimiter(numbersString);

            IEnumerable<int> numbers = numbersString.Split(delimiter).Select(s => int.TryParse(s, out int n) ? n : 0);

            CheckForNegativeNumbers(numbers);

            return numbers.Sum(num => num > 1000 ? 0 : num);
        }

        private static void CheckForNegativeNumbers(IEnumerable<int> numbers)
        {
            IEnumerable<int> negativeNumbers = numbers.Where(negative => negative < 0);

            if (negativeNumbers.Any())
                throw new ArgumentException("negatives not allowed (" + string.Join(")(", negativeNumbers) + ")");
        }

        private static char[] ReturnDelimiter(string numbersString)
        {
            List<char> delimiter = ['\n', ','];

            if (!numbersString.StartsWith("//"))
                return [.. delimiter];

            string[] checkForDelimiters = numbersString.Split('\n');
            foreach (char c in checkForDelimiters[0])
            {
                if (!int.TryParse(c.ToString(), out int num))
                    delimiter.Add(c);
            }

            return [.. delimiter];
        }
    }
}