using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_6_2
{
    public partial class Form1 : Form
    {
        Color c = Color.Red;
        List<Point> startPt = new List<Point>();
        List<Point> endPt = new List<Point>();
        List<Color> colorPt = new List<Color>();
        Point p1;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            c = Color.Green;
            rEDToolStripMenuItem.Checked = false;
            gREENToolStripMenuItem.Checked = true;
            bLUEToolStripMenuItem.Checked = false;
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = true;
            toolStripButton3.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rEDToolStripMenuItem.Checked = true;
            toolStripButton1.Checked = true;
        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Red;
            rEDToolStripMenuItem.Checked = true;
            gREENToolStripMenuItem.Checked = false;
            bLUEToolStripMenuItem.Checked = false;
            toolStripButton1.Checked = true;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = false;

        }

        private void gREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Green;
            rEDToolStripMenuItem.Checked = false;
            gREENToolStripMenuItem.Checked = true;
            bLUEToolStripMenuItem.Checked = false;
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = true;
            toolStripButton3.Checked = false;

        }

        private void bLUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Blue;
            rEDToolStripMenuItem.Checked = false;
            gREENToolStripMenuItem.Checked = false;
            bLUEToolStripMenuItem.Checked = true;
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = true;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            c = Color.Red;
            rEDToolStripMenuItem.Checked = true;
            gREENToolStripMenuItem.Checked = false;
            bLUEToolStripMenuItem.Checked = false;
            toolStripButton1.Checked = true;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = false;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            c = Color.Blue;
            rEDToolStripMenuItem.Checked = false;
            gREENToolStripMenuItem.Checked = false;
            bLUEToolStripMenuItem.Checked = true;
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            startPt.Add(p1);
            endPt.Add(e.Location);
            colorPt.Add(c);
            Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < endPt.Count(); i++)
            {
                e.Graphics.DrawLine(new Pen(colorPt[i], 1), startPt[i], endPt[i]);
            }

        }
    }
}
