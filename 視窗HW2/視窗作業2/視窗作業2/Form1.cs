using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 視窗作業2
{
    public partial class Form1 : Form
    {
        int start = 0;
        Rectangle rect1 = new Rectangle(60, 60, 180, 180);
        int[,] computer = new int[4, 4];
        int[,] player = new int[4, 4];
        Random rd = new Random();
        int cX;
        int cY;
        Color c = Color.Red;
        DialogResult dr;
        int confirm = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (start == 0)
            {
                for (int i = 1; i < 4; i++)
                    for (int j = 1; j < 4; j++)
                    {
                        computer[i, j] = 0;
                        player[i, j] = 0;
                    }
                start = 1;
            }
            Graphics g2 = this.CreateGraphics();
            for (int i = 1; i <= 4; i++)
                g2.DrawLine(Pens.Black, 60, (i) * 60, 240, (i) * 60);
            for (int i = 1; i <= 4; i++)
                g2.DrawLine(Pens.Black, (i) * 60, 60, (i) * 60, 240);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) //叉代表玩家，圈代表電腦
        {
            if (rect1.Contains(e.Location))
            {
                Graphics g1 = this.CreateGraphics();
                int x = e.X / 60;
                int y = e.Y / 60;
                if (player[x, y] == 0 && confirm != 1) //沒有被畫過
                {
                    g1.DrawLine(Pens.Black, x * 60 + 10, y * 60 + 10, x * 60 + 50, y * 60 + 50);
                    g1.DrawLine(Pens.Black, x * 60 + 50, y * 60 + 10, x * 60 + 10, y * 60 + 50);
                    player[x, y] = 1;
                    computer[x, y] = 2;
                    int num = 0;
                    for (int i = 1; i < 4; i++)
                        for (int j = 1; j < 4; j++)
                        {
                            if (player[i, j] != 0)
                                num++;
                        }
                    for (int i = 1; i <= 3; i++)
                    {
                        if (player[i, 1] == 1 && player[i, 2] == 1 && player[i, 3] == 1&& confirm != 1)
                        {
                            dr = MessageBox.Show("玩家勝利!!");
                            confirm = 1;
                        }
                        else if (player[1, i] == 1 && player[2, i] == 1 && player[3, i] == 1 && confirm != 1)
                        {
                            dr = MessageBox.Show("玩家勝利!!");
                            confirm = 1;
                        }
                    }
                    if (player[1, 1] == 1 && player[2, 2] == 1 && player[3, 3] == 1 && confirm != 1)
                    {
                        dr = MessageBox.Show("玩家勝利!!");
                        confirm = 1;
                    }
                    else if (player[1, 3] == 1 && player[2, 2] == 1 && player[3, 1] == 1 && confirm != 1)
                    {
                        dr = MessageBox.Show("玩家勝利!!");
                        confirm = 1;
                    }
                    else if (num == 9 && confirm != 1 && confirm != 1)
                    {
                        dr = MessageBox.Show("平手!!");
                        confirm = 1;
                    }
                    if (confirm != 1)
                    {
                        while (true)
                        {
                            cX = 60 + rd.Next(179);
                            cY = 60 + rd.Next(179);
                            if (computer[cX / 60, cY / 60] == 0)
                            {
                                g1.DrawEllipse(new Pen(c), (cX / 60) * 60 + 10, (cY / 60) * 60 + 10, 40, 40);
                                player[cX / 60, cY / 60] = 2;
                                computer[cX / 60, cY / 60] = 1;
                                break;
                            }
                        }
                        for (int i = 1; i <= 3; i++)
                        {
                            if (computer[i, 1] == 1 && computer[i, 2] == 1 && computer[i, 3] == 1 && confirm != 1)
                            {
                                confirm = 1;
                                dr = MessageBox.Show("電腦勝利!!");
                            }
                            else if (computer[1, i] == 1 && computer[2, i] == 1 && computer[3, i] == 1 && confirm != 1)
                            {
                                confirm = 1;
                                dr = MessageBox.Show("電腦勝利!!");
                            }
                        }
                        if (computer[1, 1] == 1 && computer[2, 2] == 1 && computer[3, 3] == 1 && confirm != 1)
                        {
                            confirm = 1;
                            dr = MessageBox.Show("電腦勝利!!");
                        }
                        else if (computer[1, 3] == 1 && computer[2, 2] == 1 && computer[3, 1] == 1 && confirm != 1)
                        {
                            confirm = 1;
                            dr = MessageBox.Show("電腦勝利!!");
                        }
                    }

                }
            }
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics h = CreateGraphics();
            h.Clear(Color.White);
            confirm = 0;
            for (int i = 1; i < 4; i++)
                for (int j = 1; j < 4; j++)
                {
                    computer[i, j] = 0;
                    player[i, j] = 0;
                }
            for (int i = 1; i <= 4; i++)
                h.DrawLine(Pens.Black, 60, (i) * 60, 240, (i) * 60);
            for (int i = 1; i <= 4; i++)
                h.DrawLine(Pens.Black, (i) * 60, 60, (i) * 60, 240);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Graphics g2 = this.CreateGraphics();
            for (int i = 1; i <= 4; i++)
                g2.DrawLine(Pens.Black, 60, (i) * 60, 240, (i) * 60);
            for (int i = 1; i <= 4; i++)
                g2.DrawLine(Pens.Black, (i) * 60, 60, (i) * 60, 240);
            for(int i=1; i<4;i++)
                for(int j=1; j<4;j++)
                {
                    if(player[i,j]==1)
                    {
                        g2.DrawLine(Pens.Black, i * 60 + 10, j * 60 + 10, i * 60 + 50, j * 60 + 50);
                        g2.DrawLine(Pens.Black, i * 60 + 50, j * 60 + 10, i * 60 + 10, j * 60 + 50);
                    }
                    if(computer[i,j]==1)
                        g2.DrawEllipse(new Pen(c), (i) * 60 + 10, (j) * 60 + 10, 40, 40);
                }
        }
    }
}
