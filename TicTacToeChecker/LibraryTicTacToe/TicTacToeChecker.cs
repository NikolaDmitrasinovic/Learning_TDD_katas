
namespace LibraryTicTacToe
{
    public class TicTacToeChecker
    {
        public static int Check(int[,] game)
        {
            int playerX = CheckVictory(game, 1);
            int playerO = CheckVictory(game, 2);

            return playerX == 1 ? playerX : playerO;
        }

        private static int CheckVictory(int[,] game, int player)
        {
            for (int i = 0; i < 3; i++)
                if (game[i, 0] == player && game[i, 1] == player && game[i, 2] == player)
                    return player;

            return -1;
        }
    }
}
