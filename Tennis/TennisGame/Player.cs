
namespace TennisGame
{
    public class Player
    {
        public int Score { get; private set; }

        public void PlayerScores()
        {
            Score++;
        }
    }
}