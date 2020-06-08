using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] pt1 = new Point[6];// 6個點, 起點=終點
            Point[] pt2 = new Point[6];
            int Cx = this.ClientSize.Width / 2; //中心點
            int Cy = this.ClientSize.Height / 2;
            int D = (int)(Math.Min(this.ClientSize.Width, this.ClientSize.Height / 2)) - 10; //半徑
            double Theta1 = -Math.PI / 2; // 初始角度 中心點正上方
            double Theta2 = -Math.PI / 2;
            for(int i=0; i<5;i++)
            {
                pt1[i].X = Cx + (int)(D * Math.Cos(Theta1));
                pt1[i].Y = Cy + (int)(D * Math.Sin(Theta1));
                pt2[i].X = Cx + (int)(D * Math.Cos(Theta2));
                pt2[i].Y = Cy + (int)(D * Math.Sin(Theta2));
                Theta1 += Math.PI * 2 / 5; //五邊形
                Theta2 += 2*Math.PI * 2 / 5; //五角形
            }
            pt1[5] = pt1[0];
            pt2[5] = pt2[0];
            e.Graphics.DrawLines(Pens.Black, pt1);
            e.Graphics.DrawLines(Pens.Black, pt2);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate(); //重新繪圖
        }
    }
}
