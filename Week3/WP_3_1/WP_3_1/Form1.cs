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

namespace WP_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen1 = new Pen(Color.Black, 3);     //數字為粗細
            pen1.DashStyle = DashStyle.Dash;        //虛線
            e.Graphics.DrawLine(pen1, 10, 10, 200, 10); //起始座標 與 結束座標
            pen1.DashStyle = DashStyle.DashDot;     // 虛線-點線
            e.Graphics.DrawLine(pen1, 10, 40, 200, 40);
            pen1.DashStyle = DashStyle.DashDotDot;  //虛線-點-點線
            e.Graphics.DrawLine(pen1, 10, 70, 200, 70);
            pen1.DashStyle = DashStyle.Dot;         //點線
            e.Graphics.DrawLine(pen1, 10, 100, 200, 100);
            pen1.DashStyle = DashStyle.Solid;       //實線
            e.Graphics.DrawLine(pen1, 10, 130, 200, 130);

            Pen pen2 = new Pen(Color.Black, 10);
            int x = 10;
            int y = 160;
            pen2.StartCap = LineCap.Flat; //扁平線端點 (開端)
            pen2.EndCap = LineCap.Flat;
            e.Graphics.DrawLine(pen2, x, y, x + 200, y);
            pen2.StartCap = LineCap.Square; //方形開端
            pen2.EndCap = LineCap.Square;
            e.Graphics.DrawLine(pen2, x, y + 30, x + 200, y + 30);
            pen2.StartCap = LineCap.Round; //圓形開端
            pen2.EndCap = LineCap.Round;
            e.Graphics.DrawLine(pen2, x, y + 60, x + 200, y + 60);
            pen2.StartCap = LineCap.Triangle; //三角形開端
            pen2.EndCap = LineCap.Triangle;
            e.Graphics.DrawLine(pen2, x, y + 90, x + 200, y + 90);
            pen2.StartCap = LineCap.SquareAnchor; //方形錨點
            pen2.EndCap = LineCap.SquareAnchor;
            e.Graphics.DrawLine(pen2, x, y + 120, x + 200, y + 120);
            pen2.StartCap = LineCap.RoundAnchor; //圓形錨點
            pen2.EndCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(pen2, x, y + 150, x + 200, y + 150);
            pen2.StartCap = LineCap.DiamondAnchor; //鑽石
            pen2.EndCap = LineCap.DiamondAnchor;
            e.Graphics.DrawLine(pen2, x, y + 180, x + 200, y + 180);
            pen2.StartCap = LineCap.ArrowAnchor;
            pen2.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen2, x, y + 210, x + 200, y + 210);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(300, 450);
        }
    }
}
