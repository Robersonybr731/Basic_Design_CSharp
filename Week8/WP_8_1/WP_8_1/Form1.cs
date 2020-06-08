﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WP_8_1
{
    public partial class Form1 : Form
    {
        HatchBrush myBrush1 = new HatchBrush(HatchStyle.Cross, Color.Red);
        float theta = 0; // 旋轉角度

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int Cx = this.ClientSize.Width / 2; // 視窗客戶區正中心點
            int Cy = this.ClientSize.Height / 2;//
            int D = 20; // 球本身的半徑
            int D2 = 100; // 球旋轉的半徑
            e.Graphics.ResetTransform(); // 畫布的矩陣 = 單位矩陣
            e.Graphics.FillEllipse(Brushes.Gray, Cx - D, Cy - D, 2 * D, 2 * D); //畫出正中心圓點 
            e.Graphics.DrawEllipse(Pens.Silver, Cx - D2, Cy - D2, 2 * D2, 2 * D2); //畫出軌道
            e.Graphics.TranslateTransform(D2, 0, MatrixOrder.Append);  // 先平移到 旋轉的半徑邊緣
            e.Graphics.RotateTransform(theta, MatrixOrder.Append);  // 乘上 旋轉矩陣
            e.Graphics.TranslateTransform(Cx, Cy, MatrixOrder.Append); // 再搬到視窗客戶區正中心點
            e.Graphics.FillEllipse(myBrush1, 0 - D, 0 - D, 2 * D, 2 * D); //畫出旋轉的圓點         


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            theta = theta + 1;  // 旋轉角度 遞增
            Invalidate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            timer1.Start();

        }
    }
}
