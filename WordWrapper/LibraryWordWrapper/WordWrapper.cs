using System.Text;

namespace LibraryWordWrapper
{
    public class WordWrapper
    {
        public static string Wrap(string textToWrap, int columnNumber = int.MaxValue)
        {
            if (textToWrap.Length <= columnNumber)
                return textToWrap;

            return textToWrap[..columnNumber] + "\n" + Wrap(textToWrap[columnNumber..], columnNumber);
        }
    }
}