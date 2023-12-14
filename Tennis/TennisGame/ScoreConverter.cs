namespace TennisGame
{
    public class ScoreConverter
    {
        public static string Convert(int score)
        {
            switch (score)
            {
                case 1: 
                    return "15";
                case 2:
                    return "30";
                default:
                    return "love";
            }
        }
    }
}