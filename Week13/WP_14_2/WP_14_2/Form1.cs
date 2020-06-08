using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_14_2
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
            //Size = new Size(1200, 800);

        }
    }
}
