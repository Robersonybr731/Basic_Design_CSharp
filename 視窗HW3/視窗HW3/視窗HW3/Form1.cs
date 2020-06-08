using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;    //DashStyle

namespace 視窗HW3
{
    public partial class Form1 : Form
    {
        int control = 0;
        Color c = Color.Red;
        List<Point> startPt = new List<Point>();
        List<Point> endPt = new List<Point>();
        List<Color> colorPt = new List<Color>();
        List<Pen> penter = new List<Pen>();
        List<Pen> test = new List<Pen>();
        int lineWidth = 1;
        bool lineSolid = true;
        Point p;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen p1 = new Pen(Color.Red);
            p1.Color = c;
            p1.Width = lineWidth;
            if (lineSolid)
                p1.DashStyle = DashStyle.Solid;
            else
                p1.DashStyle = DashStyle.Dash;
            startPt.Add(p);
            endPt.Add(e.Location);
            penter.Add(p1);
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "線段檔(*.pnt)|*.pnt";
            saveFileDialog1.Filter = "線段檔(*.pnt)|*.pnt";
            redToolStripMenuItem.Checked = true;
            solidToolStripMenuItem.Checked = true;
            toolStripMenuItem2.Checked = true; //寬度
        }

       

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startPt.Clear();
            endPt.Clear();
            penter.Clear();
            Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String s = saveFileDialog1.FileName;
                BinaryWriter outFile = new BinaryWriter(File.Open(s, FileMode.Create));
                outFile.Write(endPt.Count());
                for (int i = 0; i < endPt.Count(); i++)
                {
                    outFile.Write(startPt[i].X);
                    outFile.Write(startPt[i].Y);
                    outFile.Write(endPt[i].X);
                    outFile.Write(endPt[i].Y);

                    if (penter[i].Color == Color.Red)
                        outFile.Write(1);
                    else if (penter[i].Color == Color.Green)
                        outFile.Write(2);
                    else if (penter[i].Color == Color.Blue)
                        outFile.Write(3);

                    if (penter[i].DashStyle == DashStyle.Solid)
                        outFile.Write(1);
                    else
                        outFile.Write(2);
                   // MessageBox.Show(penter[i].Width.ToString());
                    outFile.Write(penter[i].Width);
                }
                outFile.Close();
            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String s = openFileDialog1.FileName;
                if (!File.Exists(s)) return;
                BinaryReader inFile = new BinaryReader(File.Open(s, FileMode.Open));
                startPt.Clear();
                endPt.Clear();
                penter.Clear();
                int n = inFile.ReadInt32();
                for (int i = 0; i < n; i++)
                {
                    startPt.Add(new Point(inFile.ReadInt32(), inFile.ReadInt32()));
                    endPt.Add(new Point(inFile.ReadInt32(), inFile.ReadInt32()));
                    int register;
                    Color c123 = Color.Red;
                    register = inFile.ReadInt32(); //color
                    if (register == 1)
                        c123 = Color.Red;
                    else if (register == 2)
                        c123 = Color.Green;
                    else if (register == 3)
                        c123 = Color.Blue;
                   
                    int dash123;
                    dash123 = inFile.ReadInt32(); //Dash
                    int wid = 0;
                    wid = inFile.ReadInt32();
                    if (wid == 1065353216)
                        wid = 1;
                    else if (wid == 1073741824)
                        wid = 2;
                    else if (wid == 1077936128)
                        wid = 3;
                    else if (wid == 1082130432)
                        wid = 4;
                    else
                        wid = 5;
                    //MessageBox.Show(wid.ToString());
                    Pen p123 = new Pen(Color.Red);
                    p123.Color = c123;
                    p123.Width = wid;
                   // MessageBox.Show(p123.Width.ToString());
                    if (dash123 == 1)
                        p123.DashStyle = DashStyle.Solid;
                    else
                        p123.DashStyle = DashStyle.Dash;
                   
                    penter.Add(p123);
                    control = 1;
                }
                inFile.Close();
                Invalidate();
            }

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < endPt.Count(); i++)
                e.Graphics.DrawLine(penter[i], startPt[i], endPt[i]);
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Red;
            redToolStripMenuItem.Checked = true;
            greenToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Green;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Blue;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solidToolStripMenuItem.Checked = true;
            dashToolStripMenuItem.Checked = false;
            lineSolid = true;
        }

        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solidToolStripMenuItem.Checked = false;
            dashToolStripMenuItem.Checked = true;
            lineSolid = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            lineWidth = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = true;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            lineWidth = 2;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = true;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            lineWidth = 3;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = true;
            toolStripMenuItem6.Checked = false;
            lineWidth = 4;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = true;
            lineWidth = 5;
        }
    }
}
