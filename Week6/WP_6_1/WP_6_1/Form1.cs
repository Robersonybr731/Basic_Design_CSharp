using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)) return;
            if (textBox1.Text.Equals("about:blank")) return;
            if (!textBox1.Text.StartsWith("http://") && !textBox1.Text.StartsWith("https://"))
            {
                textBox1.Text = "http://" + textBox1.Text;
            }
            try
            {
                webBrowser1.Navigate(new Uri(textBox1.Text));
            }
            catch (System.UriFormatException)
            {
                return;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoHome(); // 於 Url 屬性設定Home網址
            webBrowser1.Navigate(new Uri("http://www.yzu.edu.tw"));
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://www.yzu.edu.tw/");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = "WebBrowser控制項範例：文件名稱->" + webBrowser1.DocumentTitle +
            "，文件類型->" + webBrowser1.DocumentType;

        }
    }
}
