using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 視窗作業HW6
{
    public partial class Form1 : Form
    {
        int game_time = 120;
        int game_addition = 0;
        Bitmap[] image_set = new Bitmap[9];//幾種圖片
        Bitmap[] image_back = new Bitmap[9];//幾種圖片
        Bitmap[] image_backs = new Bitmap[9];//幾種圖片
        int back_num = 0;
        Random rands = new Random();
        int location_x = 20;
        int location_y = 300; //default
        bool is_image_set1 = false;
        bool is_image_set2 = false;
        bool is_image_set3 = false;
        int image_set1_x = 0;
        int image_set1_y = 0;
        int image_set2_x = 0;
        int image_set2_y = 0;
        int image_set3_x = 0;
        int image_set3_y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Remainning: " + game_time.ToString() + " Seconds.";
            label2.Text = "Receive: " + game_addition.ToString();
            if (game_time > 0)
            {
                game_time--;
                if (game_time % 10 == 0 && game_time != 0)
                {
                    int a = back_num;
                    do
                    {
                        back_num = rands.Next(0, 3);
                    } while (a == back_num);
                }
                if (is_image_set1 == false)
                {
                    image_set1_x = rands.Next(0, 775);
                    image_set1_y = 10;
                    is_image_set1 = true;
                }
                else
                    image_set1_y += 20;
                if (is_image_set2 == false)
                {
                    image_set2_x = rands.Next(0, 775);
                    image_set2_y = 10;
                    is_image_set2 = true;
                }
                else
                    image_set2_y += 15;
                if (is_image_set3 == false)
                {
                    image_set3_x = rands.Next(0, 775);
                    image_set3_y = 10;
                    is_image_set3 = true;
                }
                else
                    image_set3_y += 12;
                if (image_set1_y + 35 >= location_y)
                {
                    if (image_set1_x + 35 <= location_x + 70 && image_set1_x + 35 >= location_x)
                        game_addition++;
                    is_image_set1 = false;
                }
                if (image_set2_y + 35 >= location_y)
                {
                    if (image_set2_x + 35 <= location_x + 70 && image_set2_x + 35 >= location_x)
                        game_addition++;
                    is_image_set2 = false;
                }
                if (image_set3_y + 35 >= location_y)
                {
                    if (image_set3_x + 35 <= location_x + 70 && image_set3_x + 35 >= location_x)
                        game_addition++;
                    is_image_set3 = false;
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Game End! You get " + game_addition.ToString() + "points.");
            }
            Invalidate();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game_time = 120;
            game_addition = 0;
            is_image_set1 = false;
            is_image_set2 = false;
            is_image_set3 = false;
            image_set1_x = 0;
            image_set1_y = 0;
            image_set2_x = 0;
            image_set2_y = 0;
            image_set3_x = 0;
            image_set3_y = 0;
            timer1.Start();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            location_x = e.X;
            if (location_x + 70 > ClientSize.Width)
                location_x = ClientSize.Width - 70;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectDest1 = new Rectangle(0, 0, 800, 300);
            e.Graphics.DrawImage(image_backs[back_num], rectDest1);
            e.Graphics.DrawImage(image_set[0], location_x, location_y, 70, 35); //70 35 //上限location_y
            e.Graphics.DrawImage(image_set[1], image_set1_x, image_set1_y, 70, 35);
            e.Graphics.DrawImage(image_set[2], image_set2_x, image_set2_y, 70, 35);
            e.Graphics.DrawImage(image_set[3], image_set3_x, image_set3_y, 70, 35);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image_set[0] = Properties.Resources.Bowl;
            image_set[1] = Properties.Resources.Banana;
            image_set[2] = Properties.Resources.StawBerry;
            image_set[3] = Properties.Resources.Tomato;
            image_back[0] = Properties.Resources._800_8bf5a89b8d0a73611add51b2b0fa2ce1;
            image_back[1] = Properties.Resources._5_16;
            image_back[2] = Properties.Resources._2606341_image_1;
            image_backs[0] = (Bitmap)image_back[0].Clone();
            image_backs[1] = (Bitmap)image_back[1].Clone();
            image_backs[2] = (Bitmap)image_back[2].Clone();
            ClientSize = new Size(750, 400);
            backImageClone();
        }
        void backImageClone()
        {
            int x;
            int y;
            for (int i = 0; i < 3; i++)
            {
                for (x = 0; x < image_backs[i].Width; x++)
                {
                    for (y = 0; y < image_backs[i].Height; y++)
                    {
                        Color pixelColor = image_backs[i].GetPixel(x, y); // 得到圖素
                        Color newColor = pixelColor;
                        newColor = Color.FromArgb(150, pixelColor.R, pixelColor.G, pixelColor.B);
                        image_backs[i].SetPixel(x, y, newColor); // 設定圖素
                    }
                }

            }

        }

    }
}
