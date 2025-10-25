using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Birds
{
    public partial class Form1 : Form
    {
        int pipespeed = 8;
        int score = 0;
        int gravity = 15;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void game_timer(object sender, EventArgs e)
        {
            pictureBox_bird.Top += gravity;
            pictureBox_down.Left -= pipespeed;
            pictureBox_up.Left -= pipespeed;
            label1.Text = "SCORE : " + score;

            if (pictureBox_down.Left < -150)
            {
                pictureBox_down.Left = 800;
                score++;
            }
            if (pictureBox_up.Left < -180)
            {
                pictureBox_up.Left = 950;
                score++;
            }
            if (pictureBox_bird.Bounds.IntersectsWith(pictureBox_up.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_down.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_ground.Bounds) ||
                pictureBox_bird.Top < -25)
            {
                endGame();
            }
        }

            public void endGame () {
            timer1.Stop();
            label1.Text = "OYUN BITTI!";


        }

        private void game_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (timer1.Enabled)
                {
                    gravity = -15;

                }
                else
                {
                    RestartGame(); 
                }
            }
        }

        private void game_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (timer1.Enabled)
                {
                    gravity = 15;
                }
              

            }
        }
        public void RestartGame()
        {
           
            pictureBox_bird.Location = new Point(50, 150);
            pictureBox_down.Left = 800;
            pictureBox_up.Left = 950;

            score = 0;
            gravity = 15;
            pipespeed = 8; 

            timer1.Start();
        }
    }
}
