using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Connect4 : Form
    {
        Color[] color;
        int num_rows, num_columns;
        float[] columnRange;
        float radius, mouseX, eps = 6;

        public Connect4()
        {
            InitializeComponent();
            color = new Color[] { Color.Red, Color.Yellow };
        }

        private void Initialize()
        {
            Game.InitializeGame(6, 7);
            num_rows = Game.board.num_rows;
            num_columns = Game.board.num_columns;
            radius = panel1.Width / Game.board.num_columns;
            columnRange = new float[num_columns + 1];

            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics g = panel1.CreateGraphics();
            float x = eps / 2, y = panel1.Height - radius;
            for (int i = 0; i < num_rows; i++)
            {
                for (int j = 0; j < num_columns; j++)
                {
                    columnRange[j] = x;
                    g.FillEllipse(brush, x, y, radius - eps, radius - eps);
                    x += radius;
                }
                x = eps / 2;
                y -= radius;
            }
            columnRange[num_columns] = Connect4.ActiveForm.Width;
            panel2.Invalidate();
            turnPanel.Invalidate();
            UpdateScore(new List<Disc>());
            if(Game.mode == Game.Mode.ComputerVsHuman) ComputerMove();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Initialize();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(color[Game.turn]);
            e.Graphics.FillEllipse(brush, mouseX, 0, radius - eps, radius - eps);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMovement();
        }
        private void Connect4_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMovement();
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMovement();
        }

        private void OnMouseMovement()
        {
            if (columnRange == null) return;

            Point local = this.PointToClient(Cursor.Position);
            float mouseX_prev = mouseX;
            float relativeX = panel1.Left;
            for (int i = 0; i + 1 < columnRange.Length; i++)
            {
                if (columnRange[i] + relativeX <= local.X && columnRange[i + 1] + relativeX > local.X)
                {
                    mouseX = columnRange[i];
                    break;
                }
            }
            if (mouseX == mouseX_prev) return;
            panel2.Invalidate();
        }
        private bool PlayerMove()
        {
            int column = FindColumn();
            return ApplyMove(column);
        }
        private void ComputerMove()
        {
            Tuple<int, int> computerMove = Game.MiniMax(Game.difficulty, Game.turn, true);
            int column = computerMove.Item2;
            ApplyMove(column);
        }
        private bool ApplyMove(int column)
        {
            bool canAdd = Game.board.AddDisc(new Disc(column, Game.turn));
            if (canAdd == true)
            {
                Graphics g = panel1.CreateGraphics();
                SolidBrush brush = new SolidBrush(color[Game.turn]);
                float y = panel1.Height - radius - (float)(Game.board.cells[column][Game.board.sizeOfCol[column] - 1].row) * radius;
                float x = columnRange[column];
                g.FillEllipse(brush, x, y, radius - eps, radius - eps);
                Game.turn = (Game.turn + 1) % 2;
            }
            else
            {
                return false;
            }
            if (IsGameOver()) return false;
            panel2.Invalidate();
            turnPanel.Invalidate();
            return true;
        }
      
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (PlayerMove() && Game.mode != Game.Mode.HumanVsHuman)
                ComputerMove();
        }
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (PlayerMove() && Game.mode != Game.Mode.HumanVsHuman)
                ComputerMove();
        }

        private bool IsGameOver()
        {
            Tuple<int, List<Disc>> winner = Game.DoWeHaveAWinner();
            if (winner.Item1 == -1) return false;
            if (winner.Item1 == 0)
            {
                MessageBox.Show("Tie!");
            }
            else if (winner.Item1 == 1)
            {
                UpdateScore(winner.Item2);
                Game.player_1.score++;
                MessageBox.Show(Game.player_1.name + " won!");
            }
            else if (winner.Item1 == 2)
            {
                UpdateScore(winner.Item2);
                Game.player_2.score++;
                MessageBox.Show(Game.player_2.name + " won!");
            }
            UpdateLog();
            Initialize();
            return true;
        }

        private void UpdateLog()
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Log("Player 1: " + Game.player_1.name + ", Highest score: " + Game.player_1.score.ToString() +
                "\tPlayer 2: " + Game.player_2.name + ", Highest score: " + Game.player_2.score.ToString(), w);
            }
        }
        private void UpdateScore(List<Disc> success)
        {
            player1Score.Text = Game.player_1.name + "'s score: " + Game.player_1.score.ToString();
            player2Score.Text = Game.player_2.name + "'s score: " + Game.player_2.score.ToString();
            Graphics g = panel1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Green);
            for (int i = 0; i < success.Count; i++)
            {
                float y = panel1.Height - radius - (float)(success[i].row) * radius;
                float x = (float)(success[i].column) * radius + eps / 2;
                g.FillEllipse(brush, x, y, radius - eps, radius - eps);
            }
        }
        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
        }

        private int FindColumn()
        {
            for (int i = 0; i + 1 < columnRange.Length; i++)
            {
                if (columnRange[i] <= mouseX && columnRange[i + 1] > mouseX)
                    return i;
            }
            return columnRange.Length - 1;
        }

        private void turnPanel_Paint(object sender, PaintEventArgs e)
        {
            turnPanel.BackColor = color[Game.turn];
            if (Game.turn == 0) turnLabel.Text = Game.player_1.name + "'s turn.";
            else turnLabel.Text = Game.player_2.name + "'s turn.";
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect4.ActiveForm.Close();
        }

    }
}
