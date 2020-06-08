using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                Text = textBox1.Text;
            else if (textBox2.Text != "")
                Text = textBox2.Text;
            else
                Text = "No Information.";
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Text = "ERROR 1";
        }
       
    }
}
