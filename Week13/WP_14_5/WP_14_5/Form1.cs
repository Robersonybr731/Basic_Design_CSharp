using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_14_5
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
            maskedTextBox1.ValidatingType = typeof(System.DateTime);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = -1;
            switch (comboBox1.Text)
            {
                case "姓名":
                    i = this.phoneBookBindingSource.Find("姓名", textBox2.Text);
                    break;
                case "電話":
                    i = this.phoneBookBindingSource.Find("電話", textBox2.Text);
                    break;
                case "生日":
                    DateTime d;
                    if (DateTime.TryParse(textBox2.Text, out d))
                        i = this.phoneBookBindingSource.Find("出生年月日", d);
                    break;
            }
            if (i != -1)
                this.phoneBookBindingSource.Position = i;
            else
                MessageBox.Show("Not found!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.phoneBookBindingSource.Find("姓名", textBox1.Text)) != -1)
            {
                MessageBox.Show("This name exists!");
            }
            else
            {
                this.phoneBookTableAdapter.Insert(textBox1.Text, DateTime.Parse(maskedTextBox1.Text), textBox2.Text);
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

            this.phoneBookTableAdapter.Delete(textBox1.Text, DateTime.Parse(maskedTextBox1.Text), textBox2.Text);
            this.phoneBookTableAdapter.Fill(this.phoneBookDataSet.PhoneBook);

        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Incorrect Date!");
                e.Cancel = true; // 不被接受的輸入，無法下個動作，
                // 例如按“修改”按鈕會跳出警告MessageBox，也無法關閉視窗應用程式
            }
            else
            {
                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate > DateTime.Now)
                {
                    MessageBox.Show("Incorrect BirthDate");
                    e.Cancel = true; //不被接受的輸入
                }
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < DateTime.Now)
                maskedTextBox1.Text = dateTimePicker1.Value.Date.ToShortDateString();
            else
                MessageBox.Show("Incorrect BirthDate");
        }
    }
}
