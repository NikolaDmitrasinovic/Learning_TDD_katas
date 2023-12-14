
namespace TennisGame
{
    public class Game
    {
        private Player player1;
        private Player player2;

        public Game(Player _player1, Player _player2)
        {
            player1 = _player1;
            player2 = _player2;
        }

        public string CalculateScore()
        {
            if (player1.Score == player2.Score && player1.Score >= 3)
            {
                return "deuce";
            }
            else if (Math.Abs(player1.Score - player2.Score) == 1 && player1.Score >= 3 && player2.Score >= 3)
            {
                return player1.Score > player2.Score ? "player1 AD" : "player2 AD";
            }

            return ScoreConverter.Convert(player1.Score) + "-" + ScoreConverter.Convert(player2.Score);
        }
    }
}
