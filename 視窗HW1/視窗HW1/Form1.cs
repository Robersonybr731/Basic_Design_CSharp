using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 視窗HW1
{
    public partial class Form1 : Form
    {
        Rectangle rect1 = new Rectangle(0, 0, 150, 150);
        int r, g, b;
        int start = 0;
        int[,] rs1 = new int[4, 4];
        int[,] gs1 = new int[4, 4];
        int[,] bs1 = new int[4, 4];
        Brush b1;
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Graphics p = this.CreateGraphics();
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    b1 = new SolidBrush(Color.FromArgb(rs1[i, j], gs1[i, j], bs1[i, j]));
                    p.FillRectangle(b1, (i - 1) * 50, (j - 1) * 50, 50, 50);
                }
            }
            for (int i = 1; i <= 4; i++)
                p.DrawLine(Pens.Black, 0, (i - 1) * 50, 150, (i - 1) * 50);
            for (int i = 1; i <= 4; i++)
                p.DrawLine(Pens.Black, (i - 1) * 50, 0, (i - 1) * 50, 150);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g2 = this.CreateGraphics();
            for (int i = 1; i <= 3; i++)
            {
                if (start == 1)
                    break;
                for (int j = 1; j <= 3; j++)
                {
                    r = rd.Next(256);
                    g = rd.Next(256);
                    b = rd.Next(256);
                    rs1[i, j] = r;
                    gs1[i, j] = g;
                    bs1[i, j] = b;
                    b1 = new SolidBrush(Color.FromArgb(rs1[i, j], gs1[i, j], bs1[i, j]));
                    g2.FillRectangle(b1, (i - 1) * 50, (j - 1) * 50, 50, 50);
                }
            }

            for (int i = 1; i <= 4; i++)
                g2.DrawLine(Pens.Black, 0, (i - 1) * 50, 150, (i - 1) * 50);
            for (int i = 1; i <= 4; i++)
                g2.DrawLine(Pens.Black, (i - 1) * 50, 0, (i - 1) * 50, 150);
            start = 1;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rect1.Contains(e.Location))
            {
                r = rd.Next(256);
                g = rd.Next(256);
                b = rd.Next(256);
                b1 = new SolidBrush(Color.FromArgb(r, g, b));
                Graphics g1 = this.CreateGraphics();
                g1.FillRectangle(b1, (e.X / 50) * 50, (e.Y / 50) * 50, 50, 50);
                rs1[(e.X / 50) + 1, (e.Y / 50) + 1] = r;
                gs1[(e.X / 50) + 1, (e.Y / 50) + 1] = g;
                bs1[(e.X / 50) + 1, (e.Y / 50) + 1] = b;
                for (int i = 1; i <= 4; i++)
                    g1.DrawLine(Pens.Black, 0, (i - 1) * 50, 150, (i - 1) * 50);
                for (int i = 1; i <= 4; i++)
                    g1.DrawLine(Pens.Black, (i - 1) * 50, 0, (i - 1) * 50, 150);
            }
        }
    }
}
