using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_4_4
{
    public partial class Form1 : Form
    {
        Color c = Color.Red;
        public Form1()
        {
            InitializeComponent();
        }

        private void ProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Red;
            redToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Blue;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
            greenToolStripMenuItem.Checked = false;
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Green;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = true;
        }

        private void DrawToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g1 = this.CreateGraphics();
            g1.DrawEllipse(new Pen(c), 20, 40, 100, 100);
        }

        private void SquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g1 = this.CreateGraphics();
            g1.DrawRectangle(new Pen(c), 140, 40, 100, 100);
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g1 = this.CreateGraphics();
            g1.Clear(this.BackColor);
        }
    }
}
