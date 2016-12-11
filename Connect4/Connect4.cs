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
            columnRange = new float[num_columns];

            SolidBrush brush = new SolidBrush(Color.Black);
            Graphics g = panel1.CreateGraphics();
            float x = eps/2, y = panel1.Height - radius;
            for (int i = 0; i < num_rows; i++)
            {
                for (int j = 0; j < num_columns; j++)
                {
                    columnRange[j] = x;
                    g.FillEllipse(brush, x, y, radius - eps, radius - eps);
                    x += radius;
                }
                x = eps/2;
                y -= radius;
            }
            panel2.Invalidate();
            turnPanel.Invalidate();
            UpdateScore(new List<Disc>());
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
            for (int i = 0; i + 1 < columnRange.Length; i++)
            {
                if (columnRange[i] <= local.X && columnRange[i + 1] > local.X)
                {
                    mouseX = columnRange[i];
                    break;
                }
                if (i + 2 == columnRange.Length) mouseX = columnRange[i + 1];
            }
            if (mouseX == mouseX_prev) return;
            panel2.Invalidate();
        }
        private void OnMouseClick()
        {
            int column = FindColumn();
            int turn = Game.turn;
            bool canAdd = Game.board.AddDisc(new Disc(column, Game.turn));
            if (canAdd == true)
            {
                Graphics g = panel1.CreateGraphics();
                SolidBrush brush = new SolidBrush(color[turn]);
                float y = panel1.Height - radius - (float)(Game.board.cells[column][Game.board.cells[column].Count - 1].row) * radius;
                g.FillEllipse(brush, mouseX, y, radius - eps, radius - eps);
            }
            if (IsGameOver()) return;;
            panel2.Invalidate();
            turnPanel.Invalidate();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick();
        }
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick();
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
                Log("Player 1: " + Game.player_1.name+ ", Highest score: " + Game.player_1.score.ToString() +
                "\tPlayer 2: " + Game.player_2.name+ ", Highest score: " + Game.player_2.score.ToString(), w);
            }
        }
        private void UpdateScore(List<Disc> success)
        {
            player1Score.Text = Game.player_1.name + "'s Score: " + Game.player_1.score.ToString();
            player2Score.Text = Game.player_2.name + "'s Score: " + Game.player_2.score.ToString();
            Graphics g = panel1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Green);
            for (int i = 0; i < success.Count; i++)
            {
                float y = panel1.Height - radius - (float)(success[i].row) * radius;
                float x = (float)(success[i].column) * radius + eps/2;
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

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void turnPanel_Paint(object sender, PaintEventArgs e)
        {
            turnPanel.BackColor = color[Game.turn];
            if (Game.turn == 0) turnLabel.Text = Game.player_1.name + "'s turn";
            else turnLabel.Text = Game.player_2.name + "'s turn";
        }

    }
}
