namespace TennisGame
{
    public class ScoreCalculator
    {
        public static string Calculate(int player1Score, int player2Score)
        {
            if (player1Score == player2Score && player1Score >= 3)
            {
                return "deuce";
            }
            else if (Math.Abs(player1Score - player2Score) == 1 && player1Score >= 3 && player2Score >= 3)
            {
                return player1Score > player2Score ? "player1 AD" : "player2 AD";
            }

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