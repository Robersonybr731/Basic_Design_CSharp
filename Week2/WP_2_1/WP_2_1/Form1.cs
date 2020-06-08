using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Form1 Load事件 \n";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Text = "Form1 Actived事件 \n";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Form1 Click事件 \n";
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Textbox1 Click事件 \n";
        }
    }
}
