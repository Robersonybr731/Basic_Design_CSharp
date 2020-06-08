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
namespace WP_7_7
{
    public partial class Form1 : Form
    {
        Bitmap bm = new Bitmap(Properties.Resources.butterfly);
        float theta = 0; // 旋轉角度

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int Cx = this.ClientSize.Width / 2; // 視窗客戶區正中心點
            int Cy = this.ClientSize.Height / 2;//
            e.Graphics.ResetTransform(); // 畫布的矩陣 = 單位矩陣
            e.Graphics.TranslateTransform(-bm.Width , -bm.Height / 2, MatrixOrder.Append); //位移到圖中心
            e.Graphics.RotateTransform(theta, MatrixOrder.Append);
            // 乘上 旋轉矩陣
            e.Graphics.TranslateTransform(Cx, Cy, MatrixOrder.Append);
            // 再搬到視窗客戶區正中心點
            TextureBrush tb = new TextureBrush(bm);
            e.Graphics.FillRectangle(tb, 0, 0, 100, 100); // 繪出圖形

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            theta = theta + 2;  // 旋轉角度 遞增
            Invalidate();

        }
    }
}
