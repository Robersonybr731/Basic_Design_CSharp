﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_7_5
{
    public partial class Form1 : Form
    {
        Bitmap image;
        TextureBrush textureBrush;
        Pen myPen;
        int x, y;　// 紀錄上一個筆畫的起始點
        Graphics G; // 畫布物件

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; // 紀錄筆畫的起始點
            y = e.Y;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 滑鼠的左鍵
            {
                G = CreateGraphics();
                G.DrawLine(myPen, x, y, e.X, e.Y);　// 寫到　buffer

                x = e.X; // 結束點 就是 下一次的 開始點
                y = e.Y;
            }

        }

        public Form1()
        {
            InitializeComponent();
            image = new Bitmap(Properties.Resources.butterfly);
            textureBrush = new TextureBrush(image);
            myPen = new Pen(textureBrush, 100);
            ClientSize = new Size(image.Width*5, image.Height*5);
        }
    }
}
