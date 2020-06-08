using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_14_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'phoneBookDataSet.PhoneBook' 資料表。您可以視需要進行移動或移除。
            this.phoneBookTableAdapter.Fill(this.phoneBookDataSet.PhoneBook);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.phoneBookBindingSource.Find("姓名", textBox1.Text)) != -1)
            {
                MessageBox.Show("This name exists!");
            }
            else
            {
                this.phoneBookTableAdapter.Insert(textBox1.Text, DateTime.Parse(textBox2.Text), textBox3.Text);
                this.phoneBookTableAdapter.Fill(this.phoneBookDataSet.PhoneBook);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.phoneBookBindingSource.EndEdit();
            this.phoneBookTableAdapter.Update(this.phoneBookDataSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.phoneBookTableAdapter.Delete(textBox1.Text, DateTime.Parse(textBox2.Text), textBox3.Text);
            this.phoneBookTableAdapter.Fill(this.phoneBookDataSet.PhoneBook);

        }
    }
}
