﻿namespace WP_12_6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.顏色調整ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.負片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.灰階ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟舊檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟新檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.亮暗調整ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增亮ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.調暗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一半ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.兩倍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.繪圖工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.點ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.筆刷ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粗細ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(192, 23);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(192, 23);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // 顏色調整ToolStripMenuItem
            // 
            this.顏色調整ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.負片ToolStripMenuItem,
            this.灰階ToolStripMenuItem});
            this.顏色調整ToolStripMenuItem.Name = "顏色調整ToolStripMenuItem";
            this.顏色調整ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.顏色調整ToolStripMenuItem.Text = "顏色調整";
            // 
            // 負片ToolStripMenuItem
            // 
            this.負片ToolStripMenuItem.Name = "負片ToolStripMenuItem";
            this.負片ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.負片ToolStripMenuItem.Text = "負片";
            this.負片ToolStripMenuItem.Click += new System.EventHandler(this.負片ToolStripMenuItem_Click);
            // 
            // 灰階ToolStripMenuItem
            // 
            this.灰階ToolStripMenuItem.Name = "灰階ToolStripMenuItem";
            this.灰階ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.灰階ToolStripMenuItem.Text = "灰階";
            this.灰階ToolStripMenuItem.Click += new System.EventHandler(this.灰階ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.顏色調整ToolStripMenuItem,
            this.亮暗調整ToolStripMenuItem,
            this.大小ToolStripMenuItem,
            this.繪圖工具ToolStripMenuItem,
            this.筆刷ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟舊檔ToolStripMenuItem,
            this.開啟新檔ToolStripMenuItem,
            this.儲存ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開啟舊檔ToolStripMenuItem
            // 
            this.開啟舊檔ToolStripMenuItem.Name = "開啟舊檔ToolStripMenuItem";
            this.開啟舊檔ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.開啟舊檔ToolStripMenuItem.Text = "開啟舊檔";
            this.開啟舊檔ToolStripMenuItem.Click += new System.EventHandler(this.開啟舊檔ToolStripMenuItem_Click);
            // 
            // 開啟新檔ToolStripMenuItem
            // 
            this.開啟新檔ToolStripMenuItem.Name = "開啟新檔ToolStripMenuItem";
            this.開啟新檔ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.開啟新檔ToolStripMenuItem.Text = "開啟新檔";
            this.開啟新檔ToolStripMenuItem.Click += new System.EventHandler(this.開啟新檔ToolStripMenuItem_Click);
            // 
            // 儲存ToolStripMenuItem
            // 
            this.儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            this.儲存ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.儲存ToolStripMenuItem.Text = "儲存";
            this.儲存ToolStripMenuItem.Click += new System.EventHandler(this.儲存ToolStripMenuItem_Click);
            // 
            // 亮暗調整ToolStripMenuItem
            // 
            this.亮暗調整ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增亮ToolStripMenuItem,
            this.調暗ToolStripMenuItem});
            this.亮暗調整ToolStripMenuItem.Name = "亮暗調整ToolStripMenuItem";
            this.亮暗調整ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.亮暗調整ToolStripMenuItem.Text = "亮暗調整";
            // 
            // 增亮ToolStripMenuItem
            // 
            this.增亮ToolStripMenuItem.Name = "增亮ToolStripMenuItem";
            this.增亮ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.增亮ToolStripMenuItem.Text = "增亮";
            this.增亮ToolStripMenuItem.Click += new System.EventHandler(this.增亮ToolStripMenuItem_Click);
            // 
            // 調暗ToolStripMenuItem
            // 
            this.調暗ToolStripMenuItem.Name = "調暗ToolStripMenuItem";
            this.調暗ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.調暗ToolStripMenuItem.Text = "調暗";
            this.調暗ToolStripMenuItem.Click += new System.EventHandler(this.調暗ToolStripMenuItem_Click);
            // 
            // 大小ToolStripMenuItem
            // 
            this.大小ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一半ToolStripMenuItem,
            this.兩倍ToolStripMenuItem});
            this.大小ToolStripMenuItem.Name = "大小ToolStripMenuItem";
            this.大小ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.大小ToolStripMenuItem.Text = "大小調整";
            this.大小ToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.大小ToolStripMenuItem_MouseMove);
            // 
            // 一半ToolStripMenuItem
            // 
            this.一半ToolStripMenuItem.Name = "一半ToolStripMenuItem";
            this.一半ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.一半ToolStripMenuItem.Text = "一半";
            this.一半ToolStripMenuItem.Click += new System.EventHandler(this.一半ToolStripMenuItem_Click);
            // 
            // 兩倍ToolStripMenuItem
            // 
            this.兩倍ToolStripMenuItem.Name = "兩倍ToolStripMenuItem";
            this.兩倍ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.兩倍ToolStripMenuItem.Text = "兩倍";
            this.兩倍ToolStripMenuItem.Click += new System.EventHandler(this.兩倍ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 30);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // 繪圖工具ToolStripMenuItem
            // 
            this.繪圖工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.點ToolStripMenuItem,
            this.直線ToolStripMenuItem});
            this.繪圖工具ToolStripMenuItem.Name = "繪圖工具ToolStripMenuItem";
            this.繪圖工具ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.繪圖工具ToolStripMenuItem.Text = "繪圖工具";
            // 
            // 點ToolStripMenuItem
            // 
            this.點ToolStripMenuItem.Name = "點ToolStripMenuItem";
            this.點ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.點ToolStripMenuItem.Text = "點";
            this.點ToolStripMenuItem.Click += new System.EventHandler(this.點ToolStripMenuItem_Click);
            // 
            // 直線ToolStripMenuItem
            // 
            this.直線ToolStripMenuItem.Name = "直線ToolStripMenuItem";
            this.直線ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.直線ToolStripMenuItem.Text = "直線";
            this.直線ToolStripMenuItem.Click += new System.EventHandler(this.直線ToolStripMenuItem_Click);
            // 
            // 筆刷ToolStripMenuItem
            // 
            this.筆刷ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顏色ToolStripMenuItem,
            this.粗細ToolStripMenuItem});
            this.筆刷ToolStripMenuItem.Name = "筆刷ToolStripMenuItem";
            this.筆刷ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.筆刷ToolStripMenuItem.Text = "筆刷";
            // 
            // 顏色ToolStripMenuItem
            // 
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.顏色ToolStripMenuItem.Text = "顏色";
            this.顏色ToolStripMenuItem.Click += new System.EventHandler(this.顏色ToolStripMenuItem_Click);
            // 
            // 粗細ToolStripMenuItem
            // 
            this.粗細ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.粗細ToolStripMenuItem.Name = "粗細ToolStripMenuItem";
            this.粗細ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.粗細ToolStripMenuItem.Text = "粗細";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(192, 23);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem 顏色調整ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 負片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 灰階ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟舊檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟新檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 亮暗調整ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增亮ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 調暗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一半ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 兩倍ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 繪圖工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 點ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直線ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 筆刷ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粗細ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
