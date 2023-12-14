namespace TennisGame
{
    public class ScoreConverter
    {
        public static string Convert(int v)
        {
            if (v != 0)
            {
                return "15";
            }

            return "love";
        }
    }
}