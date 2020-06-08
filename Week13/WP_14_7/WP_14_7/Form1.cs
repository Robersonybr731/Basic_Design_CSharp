using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_14_7
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
            this.phoneBookTableAdapter.Fill(this.phoneBookDataSet.PhoneBook);

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.phoneBookBindingSource.EndEdit();
            this.phoneBookTableAdapter.Update(this.phoneBookDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            switch (comboBox1.Text)
            {
                case "姓名":
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (dataGridView1[0, i].Value.ToString().IndexOf(textBox1.Text) >= 0)
                        {
                            this.phoneBookBindingSource.Position = i;
                            found = true;
                        }
                    }
                    if (found != true)
                        MessageBox.Show("Not Found");
                    break;
                case "出生年月日":
                    DateTime d;
                    if (DateTime.TryParse(textBox1.Text, out d))
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            if (dataGridView1[1, i].Value.ToString().IndexOf(textBox1.Text) >= 0)
                            {
                                this.phoneBookBindingSource.Position = i;
                                found = true;
                            }
                        }
                        if (found != true)
                            MessageBox.Show("Not Found");
                    }
                    else MessageBox.Show("Unvalid Date");
                    break;
                case "電話":
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (dataGridView1[2, i].Value.ToString().IndexOf(textBox1.Text) >= 0)
                        {
                            this.phoneBookBindingSource.Position = i;
                            found = true;
                        }
                    }
                    if (found != true)
                        MessageBox.Show("Not Found");
                    break;

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //另外寫的DeleteItem回應函數，增加MessageBox提醒
            if (MessageBox.Show("Delete or not?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                phoneBookBindingSource.RemoveCurrent();
                this.phoneBookTableAdapter.Update(this.phoneBookDataSet);
            }

        }
    }
}
