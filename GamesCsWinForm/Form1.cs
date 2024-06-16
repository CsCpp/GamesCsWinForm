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
            int spead = 5;
            pictureBox1.Top += spead;
            pictureBox3.Top += spead;
          
        }
    }
}
