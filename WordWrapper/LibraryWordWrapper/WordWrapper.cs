using System.Text;

namespace LibraryWordWrapper
{
    public class WordWrapper
    {
        public static string Wrap(string textToWrap, int columnNumber)
        {
            if (textToWrap.Length <= columnNumber || columnNumber == 0)
                return textToWrap;

            return textToWrap[..columnNumber] + "\n" + Wrap(textToWrap[columnNumber..].TrimStart(), columnNumber);
        }
    }
}