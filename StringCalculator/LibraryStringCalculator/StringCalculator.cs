namespace LibraryStringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbersString)
        {
            if (string.IsNullOrEmpty(numbersString))
                return 0;

            return int.Parse(numbersString);
        }
    }
}