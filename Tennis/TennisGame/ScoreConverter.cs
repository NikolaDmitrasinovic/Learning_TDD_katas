namespace TennisGame
{
    public class ScoreConverter
    {
        public static string Convert(int score)
        {
            if (score == 1)
                return "15";
            else if (score == 2)
                return "30";

            return "love";
        }
    }
}