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
       
        public int speed_top = 10;
        public int scoreText = 0;

        public int point = 0;
        
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            ballTimer.Enabled = true;
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
            


        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void respawn()
        {

            Random r=new Random();
            int y = r.Next(100,200);
            int x = r.Next(100,1200);
            ball.Location = new Point(x,y);
            y = r.Next(100, 200);
            x = r.Next(100, 1200);
            bomb.Location = new Point(x,y);
            ballTimer.Enabled = true;
        }
        private void ballTimer_Tick(object sender, EventArgs e)
        {
            ball.Top += speed_top;
            flower.Top += speed_top;
            bomb.Top += speed_top;
            if (ball.Bottom >= plain.Top && ball.Bottom <= plain.Bottom && ball.Left >= plain.Left && ball.Right <= plain.Right)    //collision
            {
                speed_top += 1;
                scoreText++;
                score.Text = Convert.ToString(scoreText);

               
                point += 1;
                ballTimer.Enabled = false;
                respawn();
            }
            if (bomb.Bottom >= plain.Top && bomb.Bottom <= plain.Bottom && bomb.Left >= plain.Left && bomb.Right <= plain.Right)    //collision
            {
                ballTimer.Enabled = false;
                MessageBox.Show("GAME OVER");
                respawn();
                scoreText = 0;
                score.Text = "0";
                point = 0;
                speed_top = 10;
            }
            if (flower.Bottom >= plain.Top && flower.Bottom <= plain.Bottom && flower.Left >= plain.Left && flower.Right <= plain.Right)    //collision
            {
                point -= 3;
                respawnFlower();
              
            }
            
            if (ball.Left <= panel.Left)
            {
                speed_top = -speed_top;
            }

            if (ball.Right >= panel.Right)
            {
                speed_top = -speed_top;
            }

            if (ball.Top <= panel.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= panel.Bottom)
            {
                ballTimer.Enabled = false;
                MessageBox.Show("GAME OVER");
                respawn();
                scoreText = 0;
                score.Text = "0";
               point = 0;
           speed_top = 10;
             }
            if (flower.Bottom >= panel.Bottom)
            {
                respawnFlower();
            }

        }
        public void respawnFlower() {
            Random r = new Random();
            int y = r.Next(100, 200);
            int x = r.Next(100, 1200);


            flower.Location = new Point(x,y);
        }
        private void ball_Click(object sender, EventArgs e)
        {

        }
    }
}
