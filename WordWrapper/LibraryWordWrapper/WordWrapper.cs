using System.Text;

namespace LibraryWordWrapper
{
    public class WordWrapper
    {
        public static string Wrap(string textToWrap, int columnNumber = 0)
        {
            if (columnNumber == 0)
                return textToWrap;

            if (textToWrap.Length == 2)
                return textToWrap[0] + "\n" + textToWrap[1];

            StringBuilder sb = new StringBuilder();
            sb.Append(textToWrap[0]);
            for (int i = 1; i < textToWrap.Length; i++)
            {
                if (i % columnNumber == 0)
                {
                    sb.Append("\n");
                }
                sb.Append(textToWrap[i]);
            }

            return sb.ToString();
        }
    }
}