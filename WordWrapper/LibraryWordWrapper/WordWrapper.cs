using System.Text;

namespace LibraryWordWrapper
{
    public class WordWrapper
    {
        public static string Wrap(string textToWrap, int columnNumber)
        {
            if (textToWrap.Length <= columnNumber || columnNumber == 0)
                return textToWrap;

            if (textToWrap[columnNumber - 2] == ' ')
                return textToWrap.Substring(0, columnNumber - 1) + "\n" + Wrap(textToWrap.Substring(columnNumber - 1).TrimStart(), columnNumber);

            return textToWrap[..columnNumber] + "\n" + Wrap(textToWrap[columnNumber..].TrimStart(), columnNumber);
        }
    }
}