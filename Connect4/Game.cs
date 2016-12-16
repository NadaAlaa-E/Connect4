using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Game
    {
        public enum Mode { HumanVsHuman, ComputerVsHuman, HumanVsComputer };
        public static Board board;
        public static Player player_1, player_2;
        public static int turn;
        public static int difficulty;
        public static Mode mode;

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
        static int INF = int.MaxValue;

        static public Tuple<int, List<Disc>> DoWeHaveAWinner()
        {
            int tieScore = 0;
            List<Disc> success;

            #region horizontal
            for (int i = 0; i < board.num_columns; i++)
            {
                success = new List<Disc>(4);
                int countP1 = 0, countP2 = 0;
                for (int j = 0; j < board.sizeOfCol[i]; j++)
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
                    if (board.sizeOfCol[i] <= j)
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
                        if (board.sizeOfCol[i + j] <= row - j)
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
                        if (board.sizeOfCol[i + j] <= row - j)
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
                        if (board.sizeOfCol[i - j] <= row - j)
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
                        if (board.sizeOfCol[i - j] <= row - j)
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
        private static int EvaluateBoard(int player, bool isMaximizing)
        {
            int score = 0;
            for (int i = 0; i < board.num_columns; i++)
            {
                for (int j = 0; j < board.num_rows; j++)
                {
                    score += HorizontalScore(j, i, player) + VerticalScore(j, i, player)
                        + PosDiagonalScore(j, i, player) + NegDiagonalScore(j, i, player);
                }
            }
            return score + (isMaximizing ? 16 : -16);
        }
        private static int HorizontalScore(int row, int col, int player)
        {
            int score = 0, opponentScore = 0;
            for (int i = 0; i < 4; i++)
            {
                if (!board.IsValid(row, col + i)) return 0;

                if (board.cells[col + i][row] == null) continue;
                if (board.cells[col + i][row].color == player) score++;
                else if (board.cells[col + i][row].color != -1) opponentScore++;
            }
            return EvaluateSegment(score, opponentScore);
        }
        private static int VerticalScore(int row, int col, int player)
        {
            int score = 0, opponentScore = 0;
            for (int i = 0; i < 4; i++)
            {
                if (!board.IsValid(row + i, col)) return 0;

                if (board.cells[col][row + i] == null) continue;
                if (board.cells[col][row + i].color == player) score++;
                else opponentScore++;
            }
            return EvaluateSegment(score, opponentScore);
        }
        private static int PosDiagonalScore(int row, int col, int player)
        {
            int score = 0, opponentScore = 0;
            for (int i = 0; i < 4; i++)
            {
                if (!board.IsValid(row + i, col + i)) return 0;

                if (board.cells[col + i][row + i] == null) continue;
                if (board.cells[col + i][row + i].color == player) score++;
                else opponentScore++;
            }
            return EvaluateSegment(score, opponentScore);
        }
        private static int NegDiagonalScore(int row, int col, int player)
        {
            int score = 0, opponentScore = 0;
            for (int i = 0; i < 4; i++)
            {
                if (!board.IsValid(row + i, col - i)) return 0;
                if (board.cells[col - i][row + i] == null) continue;
                if (board.cells[col - i][row + i].color == player) score++;
                else opponentScore++;
            }
            return EvaluateSegment(score, opponentScore);
        }
        private static int EvaluateSegment(int playerScore, int opponentScore)
        {
            if (playerScore == 4) return 512;
            if (opponentScore == 4) return -512;
            if (opponentScore == 0)
            {
                if (playerScore == 3) return 50;
                if (playerScore == 2) return 10;
                if (playerScore == 1) return 1;
                return 0;
            }
            if (playerScore == 0)
            {
                if (opponentScore == 3) return -50;
                if (opponentScore == 2) return -10;
                if (opponentScore == 1) return -1;
                return 0;
            }
            return 0;
        }
        public static Tuple<int, int> MiniMax(int depth, int player, bool isMaximizing)
        {
            Tuple<int, int> bestChoice;
            if (depth == 0) return new Tuple<int, int>(EvaluateBoard((mode == Mode.ComputerVsHuman? 0:1), isMaximizing), -1);
            if (isMaximizing)
            {
                bestChoice = new Tuple<int, int>(-INF, -1);
                for (int i = 0; i < board.num_columns; i++)
                {
                    if (!board.AddDisc(new Disc(i, player))) continue;
                    Tuple<int, int> current = MiniMax(depth - 1, (player + 1) % 2, false);
                    board.RemoveDisc(i);
                    if (current.Item1 > bestChoice.Item1)
                    {
                        bestChoice = new Tuple<int, int>(current.Item1, i);
                    }
                }
            }
            else
            {
                bestChoice = new Tuple<int, int>(INF, -1);
                for (int i = 0; i < board.num_columns; i++)
                {
                    if (!board.AddDisc(new Disc(i, player))) continue;
                    Tuple<int, int> current = MiniMax(depth - 1, (player + 1) % 2, true);
                    board.RemoveDisc(i);
                    if (current.Item1 < bestChoice.Item1)
                        bestChoice = new Tuple<int, int>(current.Item1, i);
                }
            }
            return bestChoice;
        }
    }
}
