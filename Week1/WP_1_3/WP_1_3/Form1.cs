using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Size = new Size(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Size = new Size(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Size = new Size(Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value));
        }

        private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
