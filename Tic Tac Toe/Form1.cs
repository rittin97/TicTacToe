/*
 * Name: Rittin Shingari
 * Course: PRG655 NAA
 * Project: Tic Tac Toe
 * Due Date: 10 April 2020
 * Professor: Goran Svenk
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                TicTacToe game = new TicTacToe(false, textBox1.Text);
                Visible = false;
                if (!game.IsDisposed)
                    game.ShowDialog();
                if (game.endGame == true)
                    Application.Exit();
                Visible = true;
            }
            else
                MessageBox.Show("Enter valid IP Address or localhost");
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            btnJoin.Enabled = false;
            btnHost.Enabled = false;
            MessageBox.Show("You are the host of the game. Good Luck!");
            TicTacToe game = new TicTacToe(true);
            Visible = false;
            if (!game.IsDisposed)
                game.ShowDialog();
            if (game.endGame == true)
                Application.Exit();
            Visible = true;
        }
    }
}
