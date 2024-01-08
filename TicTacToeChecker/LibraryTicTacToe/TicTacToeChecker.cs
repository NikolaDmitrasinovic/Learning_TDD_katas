
namespace LibraryTicTacToe
{
    public class TicTacToeChecker
    {
        public static int Check(int[,] game)
        {
            if (game[0,0] == 1 && game[0,1] == 1 && game[0,2] == 1)
                return 1;
            if (game[1, 0] == 1 && game[1, 1] == 1 && game[1, 2] == 1)
                return 1;
            if (game[2, 0] == 1 && game[2, 1] == 1 && game[2, 2] == 1)
                return 1;

            if (game[0, 0] == 2 && game[0, 1] == 2 && game[0, 2] == 2)
                return 2;

            return -1;
        }
    }
}
