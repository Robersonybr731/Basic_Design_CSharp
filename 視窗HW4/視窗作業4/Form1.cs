using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 視窗作業4
{
    public partial class Form1 : Form
    {
        Color newcolor = Color.Red;
        int intervial_time = 0;
        int currentX = 26; //滑鼠位置
        int speed = 15;
        bool situation = true;
        int direction_X = 1;
        int direction_Y = 1;
        int ball_X = 40;
        int ball_Y = 60;
        Random vary=new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newcolor = Color.Red;
            toolStripButton1.Checked = true;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = false;
            Invalidate();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            newcolor = Color.Green;
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = true;
            toolStripButton3.Checked = false;
            Invalidate();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            newcolor = Color.Blue;
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = true;
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (situation)
            {
                intervial_time += 1;
                toolStripStatusLabel2.Text = "Playing";
                toolStripStatusLabel1.Text = "Game Time: " + intervial_time.ToString();
                int current_action = intervial_time % 6;
                if (current_action == 5)
                {
                    if (speed <= 30)
                        speed += 1;
                }
                if (ball_Y - 5 <= 50 && direction_Y == -1)
                    direction_Y = 1;
                else if (ball_Y + 5 >= 245 && direction_Y == 1) //要碰到地了
                {
                    if (ball_X <= currentX + 15 && ball_X >= currentX - 15) //板子碰到球
                    {
                        direction_Y = -1;
                    }
                    else if (ball_Y + 5 >= 250 && direction_Y == 1)
                    {
                        situation = false;
                    }

                }
                ball_Y += speed * direction_Y;
                if (ball_Y - 5 <= 50)
                    ball_Y = 55;
                else if (ball_Y + 5 >= 250)
                    ball_Y = 245;
                if (ball_X + 5 >= 410 && direction_X == 1)
                {
                    direction_X = -1;
                }
                else if (ball_X - 5 <= 10 && direction_X == -1)
                {
                    direction_X = 1;
                }
                ball_X += (speed * direction_X);
                if (ball_X - 5 <= 10)
                    ball_X = 15;
                else if (ball_X + 5 >= 410)
                    ball_X = 405;
                Invalidate();
            }
            else
            {
                toolStripStatusLabel2.Text = "GameOver";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = intervial_time.ToString();
            newcolor = Color.Red;
            toolStripButton1.Checked = true;
            ball_X = vary.Next(30, 350);
            ball_Y = vary.Next(100, 200);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 10, 50, 400, 200);
            Brush myBrush = new SolidBrush(Color.Red);
            e.Graphics.FillRectangle(myBrush, (currentX - 15), 250, 30, 10);
            Brush myBrush1 = new SolidBrush(newcolor);
            e.Graphics.FillEllipse(myBrush1, ball_X - 5, ball_Y - 5, 10, 10);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            situation = true;
            intervial_time = 0;
            toolStripStatusLabel2.Text = "Playing";
            ball_X = vary.Next(30, 350);
            ball_Y = vary.Next(100, 200);
            direction_X = direction_Y = 1;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Location.X > 25 && e.Location.X < 400)
                currentX = e.Location.X;
            Invalidate();
        }
    }
}
