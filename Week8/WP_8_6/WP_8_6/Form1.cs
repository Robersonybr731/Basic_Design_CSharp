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

namespace WP_8_6
{
    public partial class Form1 : Form
    {
        Pen MyPen_H = new Pen(Color.Blue, 8); // 時針使用的筆
        Pen MyPen_M = new Pen(Color.Green, 8); // 分針使用的筆
        Pen MyPen_S = new Pen(Color.Red, 6);   // 秒針使用的筆
        Pen MyPen_Frame = new Pen(Color.Black, 1); // 時鐘框架使用的筆

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.ResetTransform(); // 表單畫布 設為預設值
            e.Graphics.TranslateTransform(this.ClientSize.Width / 2,this.ClientSize.Height / 2);// 表單畫布的原點 平移到 視窗客戶區的 中心點
            e.Graphics.DrawEllipse(MyPen_Frame, -110, -110, 220, 220); // 繪出 時鐘的圓形
            // 繪出 時鐘的 12 個刻度
            for (int i = 0; i < 360; i = i + 30)
            {
                e.Graphics.ResetTransform();
                e.Graphics.TranslateTransform(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
                e.Graphics.RotateTransform(i); // 旋轉表單畫布 (每次30度)
                e.Graphics.DrawLine(MyPen_Frame, 100, 0, 110, 0); // 繪出 刻度
            }
            DateTime t = DateTime.Now; // 目前的時間
            // 繪出 時針
            e.Graphics.ResetTransform();
            e.Graphics.TranslateTransform(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            // 旋轉表單畫布 1個小時為30度 要把分鐘轉為小時的小數部分 
            e.Graphics.RotateTransform(((t.Hour % 12) + (t.Minute / 60.0f)) * 30.0f);
            e.Graphics.DrawLine(MyPen_H, 0, 0, 0, -60);
            // 繪出 分針
            e.Graphics.ResetTransform();
            e.Graphics.TranslateTransform(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            // 旋轉表單畫布 1分鐘為6度 要把秒數轉為分鐘的小數部分
            e.Graphics.RotateTransform((t.Minute + t.Second / 60.0f) * 6.0f);
            e.Graphics.DrawLine(MyPen_M, 0, 0, 0, -75);
            // 繪出 秒針
            e.Graphics.ResetTransform();
            e.Graphics.TranslateTransform(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            // 旋轉表單畫布 1秒鐘為6度
            e.Graphics.RotateTransform(t.Second * 6.0f);
            e.Graphics.DrawLine(MyPen_S, 0, 0, 0, -100);

            // 繪出 時鐘中心的小圓圈
            e.Graphics.ResetTransform();
            e.Graphics.TranslateTransform(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            e.Graphics.FillEllipse(Brushes.Brown, -10, -10, 20, 20);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate(); // 要求重畫

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            MyPen_H.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor; //箭頭的部分
            MyPen_M.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            MyPen_S.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

        }
    }
}