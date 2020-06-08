using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WP_11_3
{
    public partial class Form1 : Form
    {
        Bitmap img, img2; //  影像

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  // 開啟影像檔
            {
                String input = openFileDialog1.FileName;
                img = (Bitmap)Image.FromFile(input); // 產生一個Image物件
                if ((ClientSize.Width < img.Width) || (ClientSize.Height < img.Height))
                    ClientSize = new Size(img.Width, img.Height);
                imgClone();
                Invalidate(); // 要求重畫
            }
            //  Method 1: SetPixel
           
        }
        void imgClone()
        {
            int x, y;
            img2 = (Bitmap)img.Clone(); // 重設 img2 的 圖素
            if (radioButton1.Checked == false)
            {
                int R_rate = 0, G_rate = 0, B_rate = 0;
                Color newColor;
                if (radioButton2.Checked)
                    R_rate = 1;
                else if (radioButton3.Checked)
                    G_rate = 1;
                else if (radioButton4.Checked)
                    B_rate = 1;
                for (x = 0; x < img2.Width; x++)
                {
                    for (y = 0; y < img2.Height; y++)
                    {
                        Color pixelColor = img2.GetPixel(x, y); // 得到圖素
                        newColor = Color.FromArgb(pixelColor.R * R_rate, pixelColor.G * G_rate, pixelColor.B * B_rate);
                        img2.SetPixel(x, y, newColor); // 設定圖素
                    }
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (img2 != null)
            {
                Rectangle rectDest = new Rectangle(0, 0, img2.Width, img2.Height);
                e.Graphics.DrawImage(img2, rectDest);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (img != null)
            {
                imgClone();
                Invalidate();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (img != null)
            {
                imgClone();
                Invalidate();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (img != null)
            {
                imgClone();
                Invalidate();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (img != null)
            {
                imgClone();
                Invalidate();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
