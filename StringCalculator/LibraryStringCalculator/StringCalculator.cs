namespace LibraryStringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbersString)
        {
            if (string.IsNullOrEmpty(numbersString))
                return 0;

            if (numbersString.Length == 3)
                return int.Parse(numbersString[0].ToString()) + int.Parse(numbersString[2].ToString());

            return int.Parse(numbersString);
        }
    }
}