using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Game
    {
        public static Board board;
        public static Player player_1, player_2;
        public static int turn;
        public static void InitializeGame(int num_rows, int num_columns)
        {
            turn = 0;
            board = new Board(num_rows, num_columns);
        }
        static public void AddPlayers(string[] name)
        {
            player_1 = new Player(name[0], 1);
            player_2 = new Player(name[1], 2);
        }
        static public Tuple<int, List<Disc>> DoWeHaveAWinner()
        {
            int tieScore = 0;
            List<Disc> success;

            #region horizontal
            for (int i = 0; i < board.num_columns; i++)
            {
                success = new List<Disc>(4);
                int countP1 = 0, countP2 = 0;
                for (int j = 0; j < board.cells[i].Count; j++)
                {
                    if (board.cells[i][j].color == 0)
                    {
                        if (countP2 != 0) success.Clear();
                        success.Add(board.cells[i][j]);
                        countP1++;
                        countP2 = 0;
                    }
                    else
                    {
                        if (countP1 != 0) success.Clear();
                        success.Add(board.cells[i][j]);
                        countP1 = 0;
                        countP2++;
                    }
                    if (countP1 >= 4) return new Tuple<int, List<Disc>>(1, success);
                    if (countP2 >= 4) return new Tuple<int, List<Disc>>(2, success);
                }
            }
            #endregion
            #region vertical
            for (int j = 0; j < board.num_rows; j++)
            {
                success = new List<Disc>(4);
                int countP1 = 0, countP2 = 0;
                for (int i = 0; i < board.num_columns; i++)
                {
                    if (board.cells[i].Count <= j)
                    {
                        success.Clear();
                        countP1 = countP2 = 0;
                        continue;
                    }
                    if (board.cells[i][j].color == 0)
                    {
                        if (countP2 != 0) success.Clear();
                        success.Add(board.cells[i][j]);
                        countP1++;
                        countP2 = 0;
                    }
                    else
                    {
                        if (countP1 != 0) success.Clear();
                        success.Add(board.cells[i][j]);
                        countP1 = 0;
                        countP2++;
                    }
                    tieScore++;
                    if (countP1 >= 4) return new Tuple<int, List<Disc>>(1, success);
                    if (countP2 >= 4) return new Tuple<int, List<Disc>>(2, success);
                }
            }
            #endregion
            #region diagonal +ve
            for (int i = 0; i < board.num_columns; i++)
            {
                int countP1 = 0, countP2 = 0, row = 0, j = 0;
                while (i == 0 && row < board.num_rows)
                {
                    countP1 = countP2 = j = 0;
                    success = new List<Disc>();
                    while (j <= row)
                    {
                        if (board.cells[i + j].Count <= row - j)
                        {
                            success.Clear();
                            countP1 = countP2 = 0;
                        }
                        else if (board.cells[i + j][row - j].color == 0)
                        {
                            if (countP2 != 0) success.Clear();
                            success.Add(board.cells[i + j][row - j]);
                            countP1++;
                            countP2 = 0;
                        }
                        else if (board.cells[i + j][row - j].color == 1)
                        {
                            if (countP1 != 0) success.Clear();
                            success.Add(board.cells[i + j][row - j]);
                            countP1 = 0;
                            countP2++;
                        }
                        j++;
                        if (countP1 >= 4) return new Tuple<int, List<Disc>>(1, success);
                        if (countP2 >= 4) return new Tuple<int, List<Disc>>(2, success);
                    }
                    row++;
                }
                if (i >= 1)
                {
                    row = board.num_rows - 1; j = 0;
                    success = new List<Disc>();
                    while (i + j < board.num_columns)
                    {
                        if (board.cells[i + j].Count <= row - j)
                        {
                            success.Clear();
                            countP1 = countP2 = 0;
                        }
                        else if (board.cells[i + j][row - j].color == 0)
                        {
                            if (countP2 != 0) success.Clear();
                            success.Add(board.cells[i + j][row - j]);
                            countP1++;
                            countP2 = 0;
                        }
                        else if (board.cells[i + j][row - j].color == 1)
                        {
                            if (countP1 != 0) success.Clear();
                            success.Add(board.cells[i + j][row - j]);
                            countP1 = 0;
                            countP2++;
                        }
                        j++;
                        if (countP1 >= 4) return new Tuple<int, List<Disc>>(1, success);
                        if (countP2 >= 4) return new Tuple<int, List<Disc>>(2, success);
                    }
                }
            }
            #endregion
            #region diagonal -ve
            for (int i = board.num_columns - 1; i >= 0; i--)
            {
                int countP1 = 0, countP2 = 0, row = 0, j = 0;
                while (i == board.num_columns - 1 && row < board.num_rows)
                {
                    countP1 = countP2 = j = 0;
                    success = new List<Disc>();
                    while (j <= row)
                    {
                        if (board.cells[i - j].Count <= row - j)
                        {
                            success.Clear();
                            countP1 = countP2 = 0;
                        }
                        else if (board.cells[i - j][row - j].color == 0)
                        {
                            if (countP2 != 0) success.Clear();
                            success.Add(board.cells[i - j][row - j]);
                            countP1++;
                            countP2 = 0;
                        }
                        else if (board.cells[i - j][row - j].color == 1)
                        {
                            if (countP1 != 0) success.Clear();
                            success.Add(board.cells[i - j][row - j]);
                            countP1 = 0;
                            countP2++;
                        }
                        j++;
                        if (countP1 >= 4) return new Tuple<int, List<Disc>>(1, success);
                        if (countP2 >= 4) return new Tuple<int, List<Disc>>(2, success);
                    }
                    row++;
                }
                if (i != board.num_columns - 1)
                {
                    row = board.num_rows - 1; j = 0;
                    success = new List<Disc>();
                    while (i - j >= 0)
                    {
                        if (board.cells[i - j].Count <= row - j)
                        {
                            success.Clear();
                            countP1 = countP2 = 0;
                        }
                        else if (board.cells[i - j][row - j].color == 0)
                        {
                            if (countP2 != 0) success.Clear();
                            success.Add(board.cells[i - j][row - j]);
                            countP1++;
                            countP2 = 0;
                        }
                        else if (board.cells[i - j][row - j].color == 1)
                        {
                            if (countP1 != 0) success.Clear();
                            success.Add(board.cells[i - j][row - j]);
                            countP1 = 0;
                            countP2++;
                        }
                        j++;
                        if (countP1 >= 4) return new Tuple<int, List<Disc>>(1, success);
                        if (countP2 >= 4) return new Tuple<int, List<Disc>>(2, success);
                    }
                }
            }
            #endregion

            if (tieScore == board.num_rows * board.num_columns) return new Tuple<int, List<Disc>>(0, new List<Disc>());
            return new Tuple<int, List<Disc>>(-1, new List<Disc>());
        }
    }
}
