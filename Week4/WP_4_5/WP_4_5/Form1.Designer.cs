﻿namespace WP_4_5
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.線段粗細ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.線段型式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox4 = new System.Windows.Forms.ToolStripComboBox();
            this.背景顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.白ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.灰ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銀ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.線段粗細ToolStripMenuItem,
            this.線段型式ToolStripMenuItem,
            this.背景顏色ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // 線段粗細ToolStripMenuItem
            // 
            this.線段粗細ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.線段粗細ToolStripMenuItem.Name = "線段粗細ToolStripMenuItem";
            this.線段粗細ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.線段粗細ToolStripMenuItem.Text = "線段粗細";
            // 
            // 線段型式ToolStripMenuItem
            // 
            this.線段型式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2,
            this.toolStripComboBox4});
            this.線段型式ToolStripMenuItem.Name = "線段型式ToolStripMenuItem";
            this.線段型式ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.線段型式ToolStripMenuItem.Text = "線段形式";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 31);
            this.toolStripComboBox1.Click += new System.EventHandler(this.ToolStripComboBox1_Click);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "實線",
            "虛線"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 31);
            this.toolStripComboBox2.Click += new System.EventHandler(this.ToolStripComboBox2_Click);
            // 
            // toolStripComboBox4
            // 
            this.toolStripComboBox4.Items.AddRange(new object[] {
            "藍色",
            "綠色",
            "紅色"});
            this.toolStripComboBox4.Name = "toolStripComboBox4";
            this.toolStripComboBox4.Size = new System.Drawing.Size(121, 31);
            this.toolStripComboBox4.Click += new System.EventHandler(this.ToolStripComboBox4_Click);
            // 
            // 背景顏色ToolStripMenuItem
            // 
            this.背景顏色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.白ToolStripMenuItem,
            this.灰ToolStripMenuItem,
            this.銀ToolStripMenuItem});
            this.背景顏色ToolStripMenuItem.Name = "背景顏色ToolStripMenuItem";
            this.背景顏色ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.背景顏色ToolStripMenuItem.Text = "背景顏色";
            // 
            // 白ToolStripMenuItem
            // 
            this.白ToolStripMenuItem.Checked = true;
            this.白ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.白ToolStripMenuItem.Name = "白ToolStripMenuItem";
            this.白ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.白ToolStripMenuItem.Text = "白";
            this.白ToolStripMenuItem.Click += new System.EventHandler(this.白ToolStripMenuItem_Click);
            // 
            // 灰ToolStripMenuItem
            // 
            this.灰ToolStripMenuItem.Name = "灰ToolStripMenuItem";
            this.灰ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.灰ToolStripMenuItem.Text = "灰";
            this.灰ToolStripMenuItem.Click += new System.EventHandler(this.灰ToolStripMenuItem_Click);
            // 
            // 銀ToolStripMenuItem
            // 
            this.銀ToolStripMenuItem.Name = "銀ToolStripMenuItem";
            this.銀ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.銀ToolStripMenuItem.Text = "銀";
            this.銀ToolStripMenuItem.Click += new System.EventHandler(this.銀ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 線段粗細ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem 線段型式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox4;
        private System.Windows.Forms.ToolStripMenuItem 背景顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 白ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 灰ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銀ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

