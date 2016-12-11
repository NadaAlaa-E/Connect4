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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            p1error.Visible = p2error.Visible = false;

            if (player1Txt.Text.Length == 0)
            {
                player1Txt.Focus();
                p1error.Visible = true;
                return;
            }
            if (player2Txt.Text.Length == 0)
            {
                player2Txt.Focus();
                p2error.Visible = true;
                return;
            }
            string[] players = new string[]{player1Txt.Text, player2Txt.Text};
            Game.AddPlayers(players);

            Connect4 frm = new Connect4();
            frm.Show();
        }
    }
}
