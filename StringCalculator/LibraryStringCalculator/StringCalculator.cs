namespace LibraryStringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbersString)
        {
            if (!string.IsNullOrEmpty(numbersString))
                return int.Parse(numbersString);

            return 0;
        }
    }
}