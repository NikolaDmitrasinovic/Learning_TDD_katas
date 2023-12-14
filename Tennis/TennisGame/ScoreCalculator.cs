namespace TennisGame
{
    public class ScoreCalculator
    {
        public static string Calculate(int player1Score, int player2Score)
        {
            string score;

            if (IsDeuce(player1Score, player2Score))
            {
                score =  "deuce";
            }
            else if (IsAdvantage(player1Score, player2Score))
            {
                score = player1Score > player2Score && player1Score >= 3 && player2Score >= 3 ? "player1 AD" : "player2 AD";
            }
            else
            {
                score = GetTennisScore(player1Score) + "-" + GetTennisScore(player2Score);
            }

            return score;
        }

        private static bool IsDeuce(int player1Score, int player2Score)
        {
            return player1Score == player2Score && player1Score >= 3 && player2Score >= 3;
        }

        private static bool IsAdvantage(int player1Score, int player2Score)
        {
            return Math.Abs(player1Score - player2Score) == 1;
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