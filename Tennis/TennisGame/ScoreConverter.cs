namespace TennisGame
{
    public class ScoreConverter
    {
        public static string Convert(int player1Score, int player2Score)
        {
            return GetTennisScore(player1Score) + "-" + GetTennisScore(player2Score);
        }

        private static string GetTennisScore(int score)
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