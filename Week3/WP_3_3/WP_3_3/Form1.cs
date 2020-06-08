using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_3_3
{
    public partial class Form1 : Form
    {
        Rectangle rect; //矩形區域
        int D = 1; //增加的速度
        public Form1()
        {
            InitializeComponent();
            int x = this.ClientSize.Width / 2;  //視窗客戶區的中心點
            int y = this.ClientSize.Height / 2;
            rect = new Rectangle(x - 50, y - 50, 100, 100); //寬高為100的矩形區域
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, rect); //繪出矩形
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(rect.Bottom>=this.ClientSize.Height||rect.Top<=0||rect.Left<=0
                ||rect.Right>=this.ClientSize.Width) //擴張到邊界
            {
                D = -1; //反向收縮 
            }
            else if(rect.Height<10)
            {
                D = 1;
            }
            rect.Inflate(D, D); //擴張或收縮
            Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width / 2;
            int y = this.ClientSize.Height / 2;
            rect = new Rectangle(x - 50, y - 50, 100, 100);
        }
    }
}
