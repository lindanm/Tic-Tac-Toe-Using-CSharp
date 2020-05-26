using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTicTacToe
{
    public partial class Games : Form
    {
        bool turn = true; //true= x turn, false = o turn
        int turn_count = 0;

        public Games()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            cekPemenang();

        }

        private void cekPemenang()
        {
            bool ada_pemenang = false;
            //cek horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                ada_pemenang = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                ada_pemenang = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                ada_pemenang = true;

            //vertical cek
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                ada_pemenang = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                ada_pemenang = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                ada_pemenang = true;

            //cek diagonal
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                ada_pemenang = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                ada_pemenang = true;

            if (ada_pemenang)
            {
                String winner = "";
                if (turn)
                {
                    winner = "O";
                    poinO.Text = (Int32.Parse(poinO.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    poinX.Text = (Int32.Parse(poinX.Text) + 1).ToString();
                }
                MessageBox.Show(winner + ", Selamat Anda Menang!", "Congratulation");
                reset();
            }
            else
            {
                if (turn_count == 9)
                {
                    poinDraw.Text = (Int32.Parse(poinDraw.Text) + 1).ToString();
                    MessageBox.Show("Draw, Tidak ada yang menang atau kalah :)", "Congratulation");
                    reset();
                }
            }                        
        }
                
        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void playAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poinO.Text = "0";
            poinX.Text = "0";
            poinDraw.Text = "0";

            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void reset()
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }

        private void Games_Load(object sender, EventArgs e)
        {

        }
        
    }
}
