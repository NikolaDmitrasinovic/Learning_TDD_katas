
namespace LibraryTicTacToe
{
    public class TicTacToeChecker
    {
        public static int Check(int[,] game)
        {
            if (game[0,0] == 1 && game[0,1] == 1 && game[0,2] == 1)
                return 1;

            return -1;
        }
    }
}
