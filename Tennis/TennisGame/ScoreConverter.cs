namespace TennisGame
{
    public class ScoreConverter
    {
        public static string Convert(int score)
        {
            if (score != 0)
                return "15";

            return "love";
        }
    }
}