namespace TennisGame
{
    public class ScoreCalculator
    {
        public static string Calculate(int player1Score, int player2Score)
        {
            if (IsVictor(player1Score, player2Score))
                return "player1 WON";

            if (IsVictor(player2Score, player1Score))
                return "player2 WON";

            return PassDeuce(player1Score, player2Score) ? 
                Deuce(player1Score, player2Score) + Advantage(player1Score, player2Score) :
                GetTennisScore(player1Score) + "-" + GetTennisScore(player2Score);
        }

        private static bool IsVictor(int player1Score, int player2Score)
        {
            return player1Score >= 4 && player1Score - player2Score >= 2;
        }

        private static bool PassDeuce(int player1Score, int player2Score)
        {
            return player1Score >= 3 && player2Score >= 3;
        }

        private static string Deuce(int player1Score, int player2Score)
        {
            return player1Score == player2Score ? "deuce" : "";
        }

        private static string Advantage(int player1Score, int player2Score)
        {
            if (player1Score == player2Score)
                return "";

            return player1Score > player2Score ? "player1 AD" : "player2 AD";
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