using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_7_6
{
    public partial class Form1 : Form
    {
        Bitmap bm = new Bitmap(Properties.Resources.butterfly);
        Point pos = new Point(); // 圖形的位置

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(pos.X, pos.Y);
            TextureBrush tb = new TextureBrush(bm);
            e.Graphics.FillRectangle(tb, 0, 0, 100, 100); // 繪出圖形

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)   // 上
                pos = new Point(pos.X, pos.Y - 10);
            else if (e.KeyData == Keys.Down) // 下
                pos = new Point(pos.X, pos.Y + 10);
            else if (e.KeyData == Keys.Left) // 左
                pos = new Point(pos.X - 10, pos.Y);
            else if (e.KeyData == Keys.Right) // 右
                pos = new Point(pos.X + 10, pos.Y);
            Invalidate();

        }
    }
}
