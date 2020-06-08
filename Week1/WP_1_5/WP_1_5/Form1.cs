﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //新增Listbox物件的選項
            listBox1.Items.AddRange(
                new object[] {
                    "滑鼠",
                    "鍵盤",
                    "網卡",
                    "螢幕",
                    "音效卡"
                });
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "目前位置 : " + listBox1.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 如果textBox2沒有指定要插入的位置，就插入到最後一筆
            // 如果textBox2有指定位置，就插到指定位置
            if (textBox2.Text == "")
                listBox1.Items.Insert(listBox1.Items.Count, textBox1.Text);
            else
            {
                int ndx = Convert.ToInt32(textBox2.Text);
                listBox1.Items.Insert(ndx, textBox1.Text);
            }
            textBox1.Clear();
            label1.Text = "目前位置 :" + listBox1.SelectedIndex;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string searchstring = textBox1.Text;
            // 查詢ListBox的選項中，是否存在待搜尋的字串
            int index = listBox1.FindString(searchstring);

            // 如果找不到，其傳回值為-1
            if (index != -1)
                listBox1.SetSelected(index, true);
            else
                MessageBox.Show("目前的ListBox中並沒有要查尋的「" + searchstring + "」");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // textBox2的內容是指定要移除的位置，刪除指定位置的選項
            if(textBox2.Text!="")
            {
                int a = Convert.ToInt32(textBox2.Text);
                if (a < listBox1.Items.Count)
                    listBox1.Items.RemoveAt(a);
            }
        }
    }
}
