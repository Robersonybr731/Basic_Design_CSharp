using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_12_7
{
    public partial class Form3 : Form
    {
        private float R = 1, G = 1, B = 1, A = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            R = (float)trackBar1.Value / 100;
            G = (float)trackBar2.Value / 100;
            B = (float)trackBar3.Value / 100;
            A = (float)trackBar4.Value / 100;
            Close();
        }
        public float getR()
        { //For Form1 to get width
            return R;
        }
        public float getG()
        { //For Form1 to get width
            return G;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar3.Value.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label8.Text = trackBar4.Value.ToString();
        }

        public float getB()
        { //For Form1 to get width
            return B;
        }
        public float getA()
        { //For Form1 to get width
            return A;
        }


        public Form3()
        {
            InitializeComponent();
        }
    }
}
