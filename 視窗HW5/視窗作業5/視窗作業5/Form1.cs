using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 視窗作業5
{
    public partial class Form1 : Form
    {
        bool enables = true;
        Rectangle rec = new Rectangle(0, 50, 200, 200);
        Random rands = new Random();
        Image[] image_set = new Image[9];//幾種圖片     固定不變
        int[] image_numbers = new int[9]; //最多只有2次 固定不變
        Image[] total_set = new Image[17];//幾種圖片 1開始放
        Image[] default_set = new Image[17];//幾種圖片 1開始放
        Image buffer_image = Properties.Resources._8_0;
        int buffer_index = 0;
        int gametime = 0;
        int covernumber = 0;
        int millisecondsTimeout = 1000; // 1 sec
        int quick = 0;
        public Form1()
        {
            image_set[0] = Properties.Resources._8_0;
            image_set[1] = Properties.Resources._8_1;
            image_set[2] = Properties.Resources._8_2;
            image_set[3] = Properties.Resources._8_3;
            image_set[4] = Properties.Resources._8_4;
            image_set[5] = Properties.Resources._8_5;
            image_set[6] = Properties.Resources._8_6;
            image_set[7] = Properties.Resources._8_7;
            image_set[8] = Properties.Resources._8_8;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
                image_numbers[i] = 2;
            for (int i = 1; i < 17; i++)
            {
                int selects;
                do
                {
                    selects = rands.Next(1, 9);
                } while (image_numbers[selects] == 0);
                total_set[i] = image_set[selects];
                image_numbers[selects]--;
            }
            for (int i = 0; i < 17; i++)
                default_set[i] = Properties.Resources._8_0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 1; i < 6; i++)
                e.Graphics.DrawLine(Pens.Black, 0, 50 * i, 200, 50 * i);
            for (int i = 1; i < 5; i++)
                e.Graphics.DrawLine(Pens.Black, 50 * i, 50, 50 * i, 250);
            int a = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    e.Graphics.DrawImage(default_set[a], j * 50 + 2, i * 50 + 2, 48, 48);
                    a++;
                    if (a == 17)
                        break;
                }
                if (a == 17)
                    break;
            }
            if (covernumber == 16)
                MessageBox.Show("End! Time: " + gametime.ToString());
            enables = true;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rec.Contains(e.Location) && enables == true && covernumber!=16)
            {
                int current_x = e.X;
                int current_Y = e.Y;
                int indexs = current_x / 50 + (current_Y / 50 - 1) * 4 + 1;
                //MessageBox.Show(indexs.ToString());
                //default_set[indexs] = total_set[indexs];
                if (buffer_index == 0)
                {
                    buffer_image = total_set[indexs];
                    buffer_index = indexs;
                    default_set[indexs] = total_set[indexs]; //翻過來
                }
                else //已經有東西
                {
                    default_set[indexs] = total_set[indexs]; //翻過來

                    if (buffer_image == total_set[indexs]) //一樣
                    {
                        buffer_image = Properties.Resources._8_0;
                        buffer_index = 0;
                        covernumber += 2;
                    }
                    else //不一樣
                    {
                        Graphics ue = this.CreateGraphics();
                        int a = 1;
                        for (int i = 1; i < 5; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                ue.DrawImage(default_set[a], j * 50 + 2, i * 50 + 2, 48, 48);
                                a++;
                                if (a == 17)
                                    break;
                            }
                            if (a == 17)
                                break;
                        }
                        enables = false;
                        System.Threading.Thread.Sleep(millisecondsTimeout);
                        default_set[buffer_index] = Properties.Resources._8_0;
                        default_set[indexs] = Properties.Resources._8_0;
                        buffer_image = Properties.Resources._8_0;
                        buffer_index = 0;
                    }
                }
                Invalidate();
             
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gametime++;
            label1.Text = gametime.ToString();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
                image_numbers[i] = 2;
            for (int i = 1; i < 17; i++)
            {
                int selects;
                do
                {
                    selects = rands.Next(1, 9);
                } while (image_numbers[selects] == 0);
                total_set[i] = image_set[selects];
                image_numbers[selects]--;
            }
            for (int i = 0; i < 17; i++)
                default_set[i] = Properties.Resources._8_0;
            enables = true;
            buffer_image = Properties.Resources._8_0;
            buffer_index = 0;
            gametime = 0;
            covernumber = 0;
            timer1.Start();
            Invalidate();
        }
    }
}
