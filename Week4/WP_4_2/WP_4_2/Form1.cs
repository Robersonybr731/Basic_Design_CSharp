using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_4_2
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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                label3.Text = "答對了";
            else
                label3.Text = "答錯了，元智大學於1989年招收第一屆學生";
            if (radioButton6.Checked == true)
                label4.Text = "答對了";
            else
                label4.Text = "答錯了，元智大學位於桃園市";

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
