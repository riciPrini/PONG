using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerriPong
{
    public partial class Form1 : Form
    {
        public int speed_ball = 20;  
        public int speed_top = 4;
        public int point = 0;
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();   
            this.FormBorderStyle = FormBorderStyle.None;  
            this.TopMost = true;  
            this.Bounds = Screen.PrimaryScreen.Bounds; 
            plain.Top = panel.Bottom - (panel.Bottom / 10);
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Escape) { this.Close();}        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            plain.Left = Cursor.Position.X - (plain.Width / 2);   
            ball.Left += speed_ball;     //move the ball
            ball.Top += speed_top;

            if (ball.Bottom >= plain.Top && ball.Bottom <= plain.Bottom && ball.Left >= plain.Left && ball.Right <= plain.Right)    //collision
            {
                speed_top += 2;
                speed_ball += 2;
                speed_top = -speed_top;// change the direction
                point += 1;
            }
            if (ball.Left <= panel.Left)
            {
                speed_ball = -speed_ball;
            }
            if (ball.Right >= panel.Right)
            {
                speed_ball = -speed_ball;
            }
            if (ball.Top <= panel.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= panel.Bottom)
            {
                timer1.Enabled = false; 
            }

        }
    }
}
