﻿
namespace LibraryTicTacToe
{
    public class TicTacToeChecker
    {
        public static int Check(int[,] game)
        {
            if (IsVictroyRow(game, 1) || IsVictroyColumn(game, 1))
                return 1;

            if (IsVictroyRow(game, 2) || IsVictroyColumn(game, 2))
                return 2;

            return -1;
        }

        private static bool IsVictroyRow(int[,] game, int player)
        {
            for (int i = 0; i < 3; i++)
                if (game[i, 0] == player && game[i, 1] == player && game[i, 2] == player)
                    return true;

            return false;
        }

        private static bool IsVictroyColumn(int[,] game, int player)
        {
            for (int i = 0; i < 3; i++)
                if (game[0, i] == player && game[1, i] == player && game[2, i] == player)
                    return true;

            return false;
        }
    }
}
