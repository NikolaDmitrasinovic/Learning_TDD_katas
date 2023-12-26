namespace LibraryWordWrapper
{
    public class WordWrapper
    {
        public static string Wrap(string textToWrap, int columnNumber = 0)
        {
            if (columnNumber == 0)
                return textToWrap;

            return textToWrap[0] + "\n" + textToWrap[1];
        }
    }
}