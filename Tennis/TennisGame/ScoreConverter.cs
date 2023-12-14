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
                case 3:
                    return "40";
                default:
                    return "love";
            }
        }
    }
}