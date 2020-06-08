using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WP_14_8
{
    public partial class Form1 : Form
    {
        Image apple = Properties.Resources._8_1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'studentRecordDataSet.StudentRecord' 資料表。您可以視需要進行移動或移除。
            this.studentRecordTableAdapter.Fill(this.studentRecordDataSet.StudentRecord);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((this.studentRecordBindingSource.Find("StudentID", textBox1.Text)) != -1)
            {
                MessageBox.Show("This ID exists!");
            }
            else
            {
                int mid = int.Parse(textBox4.Text);
                int final = int.Parse(textBox5.Text);
                if (mid < 0 || mid > 100)
                    MessageBox.Show("MidExam Error. Please Enter number 0~100 !");
                else if (final < 0 || final > 100)
                    MessageBox.Show("FinalExam Error. Please Enter number 0~100 !");
                else
                {
                    this.studentRecordTableAdapter.Insert(textBox1.Text, textBox2.Text, comboBox2.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
                    this.studentRecordTableAdapter.Fill(this.studentRecordDataSet.StudentRecord);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mid = int.Parse(textBox4.Text);
            int final = int.Parse(textBox5.Text);
            if (mid < 0 || mid > 100)
                MessageBox.Show("MidExam Error. Please Enter number 0~100 !");
            else if (final < 0 || final > 100)
                MessageBox.Show("FinalExam Error. Please Enter number 0~100 !");
            else
            {
                this.studentRecordBindingSource.EndEdit();
                this.studentRecordTableAdapter.Update(this.studentRecordDataSet);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.studentRecordTableAdapter.Delete(textBox1.Text, textBox2.Text, comboBox2.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            this.studentRecordTableAdapter.Fill(this.studentRecordDataSet.StudentRecord);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = -1;
            switch (comboBox1.Text)
            {
                case "Name":
                    i = this.studentRecordBindingSource.Find("StudentName", textBox6.Text);
                    break;
                case "ID":
                    i = this.studentRecordBindingSource.Find("StudentID", textBox6.Text);
                    break;
            }
            if (i != -1)
                this.studentRecordBindingSource.Position = i;
            else
                MessageBox.Show("Not found!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text);
            int b = int.Parse(textBox5.Text);
            int average = (a + b) / 2;
            label8.Text = average.ToString();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int a = int.Parse(textBox4.Text);
            int b = int.Parse(textBox5.Text);
            int average = (a + b) / 2;
            if (average >= 60)
                e.Graphics.DrawImage(apple, 600, 30, 30, 30);
            if (average >= 70)
                e.Graphics.DrawImage(apple, 630, 30, 30, 30);
            if (average >= 80)
                e.Graphics.DrawImage(apple, 660, 30, 30, 30);
            if (average >= 90)
                e.Graphics.DrawImage(apple, 690, 30, 30, 30);
        }
    }
}
