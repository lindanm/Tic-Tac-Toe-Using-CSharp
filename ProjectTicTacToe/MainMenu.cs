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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HowToPlay htp = new HowToPlay();
            this.Hide();
            htp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Games menu = new Games();
            this.Hide();
            menu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            About abt = new About();
            this.Hide();
            abt.ShowDialog();
        }
    }
}
