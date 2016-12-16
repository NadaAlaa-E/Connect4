using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class StartPageForm : Form
    {
        public StartPageForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string[] players;
            p1error.Visible = p2error.Visible = false;

            if (player1Txt.Text.Length == 0)
            {
                player1Txt.Focus();
                p1error.Visible = true;
                return;
            }
            if (Game.mode == Game.Mode.HumanVsHuman)
            {
                if (player2Txt.Text.Length == 0)
                {
                    player2Txt.Focus();
                    p2error.Visible = true;
                    return;
                }
                players = new string[] { player1Txt.Text, player2Txt.Text };
            }
            else if (Game.mode == Game.Mode.ComputerVsHuman)
            {
                players = new string[] { "Computer", player1Txt.Text };
            }
            else
            {
                players = new string[] { player1Txt.Text, "Computer" };
            }

            Game.AddPlayers(players);
            StartGame();
        }

        private void humanVsHumanButton_Click(object sender, EventArgs e)
        {
            Game.mode = Game.Mode.HumanVsHuman;
            PlayerInfoPanel.BringToFront();
            StartUpPanel.Enabled = false;
        }

        private void humanVsComputerButton_Click(object sender, EventArgs e)
        {
            Game.mode = Game.Mode.HumanVsComputer;
            SetDifficulty();
            PlayerInfoPanel.BringToFront();
            StartUpPanel.Enabled = false;
        }

        private void computerVsHumanButton_Click(object sender, EventArgs e)
        {
            Game.mode = Game.Mode.ComputerVsHuman;
            SetDifficulty();
            PlayerInfoPanel.BringToFront();
            StartUpPanel.Enabled = false;
        }

        private void StartGame()
        {
            StartUpPanel.BringToFront();
            Connect4 frm = new Connect4();
            frm.Show();
        }

        private void SetDifficulty()
        {
            if (easyToolStripMenuItem.Checked == true) Game.difficulty = 1;
            if (mediumToolStripMenuItem.Checked == true) Game.difficulty = 2;
            if (hardToolStripMenuItem.Checked == true) Game.difficulty = 4;
        }

        private void PlayerInfoPanel_Paint(object sender, PaintEventArgs e)
        {
            if (Game.mode == Game.Mode.HumanVsHuman)
            {
                player2Txt.Show();
                player2Name.Show();
            }
            else
            {
                player2Txt.Hide();
                player2Name.Hide();
            }
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediumToolStripMenuItem.Checked = hardToolStripMenuItem.Checked = false;
            easyToolStripMenuItem.Checked = true;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem.Checked = hardToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = true;
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediumToolStripMenuItem.Checked = easyToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = true;
        }

        public void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartUpPanel.Enabled = true;
            StartUpPanel.BringToFront();
        }
    }
}
