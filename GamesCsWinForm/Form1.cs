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
            pictureBox1.MouseDown += MouseDownClicK;
            pictureBox1.MouseUp += MouseUpClicK;
            pictureBox1.MouseMove += MouseMoveClicK;
            pictureBox3.MouseDown += MouseDownClicK;
            pictureBox3.MouseUp += MouseUpClicK;
            pictureBox3.MouseMove += MouseMoveClicK;


        }
        private void MouseDownClicK(object sender, MouseEventArgs e)
        {
            dragging = true;
            point = e.Location;
            
        }
        private void MouseMoveClicK(object sender, MouseEventArgs e)
        {
            if (dragging)
            { 
             Point corPoint=PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(corPoint.X-point.X, corPoint.Y-point.Y+pictureBox1.Top);
            }
        }
        private void MouseUpClicK(object sender, MouseEventArgs e)
        {
            dragging = false;

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
