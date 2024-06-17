using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesCsWinForm
{
    public partial class Form1 : Form
    {
        private Point point;
        private bool dragging;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) { this.Close(); }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top >= 400)
            {
                pictureBox1.Top = 0;

                pictureBox3.Top = -400;
                return;
            }
            int spead = 3;
            pictureBox1.Top += spead;
            pictureBox3.Top += spead;
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 3;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left>100) 
            { 
            player.Left -= speed;
            }
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right<500)
            {
                player.Left += speed;
            }

        }
    }
}
