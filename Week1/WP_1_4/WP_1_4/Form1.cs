using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox3.Text);
            double b = double.Parse(textBox4.Text);
            double c = a - b;
            label11.Text = c.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox7.Text);
            double b = double.Parse(textBox8.Text);
            double c = a / b;
            label13.Text = c.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox9.Text);
            double b = double.Parse(textBox11.Text);
            b /= 100; //convert to m
            double bmi = a / Math.Pow(b, 2);
            label14.Text = bmi.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = a + b;
            label10.Text = c.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox5.Text);
            double b = double.Parse(textBox6.Text);
            double c = a * b;
            label12.Text = c.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox10.Text);
            double b = double.Parse(textBox12.Text);
            double c = double.Parse(textBox13.Text);
            double d = 0;
            for (double i = a; i <= b; i += c)
                d += i;
            label15.Text = d.ToString();
        }
    }
}
