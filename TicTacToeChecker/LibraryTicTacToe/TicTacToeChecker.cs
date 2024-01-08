
namespace LibraryTicTacToe
{
    public class TicTacToeChecker
    {
        public static int Check(int[,] game)
        {
            for (int i = 0; i < 3; i++)
            {
                if (game[i, 0] == 1 && game[i, 1] == 1 && game[i, 2] == 1)
                    return 1;
            }

            for (int i = 0; i < 3; i++)
            {
                if (game[i, 0] == 2 && game[i, 1] == 2 && game[i, 2] == 2)
                    return 2;
            }

            return -1;
        }
    }
}
