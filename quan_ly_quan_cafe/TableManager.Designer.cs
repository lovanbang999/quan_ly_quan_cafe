﻿namespace quan_ly_quan_cafe
{
    partial class TableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LsBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.BtnAddFood = new System.Windows.Forms.Button();
            this.CbFood = new System.Windows.Forms.ComboBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.FlpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnDiscount = new System.Windows.Forms.Button();
            this.NmDisCount = new System.Windows.Forms.NumericUpDown();
            this.BtnSwitchTable = new System.Windows.Forms.Button();
            this.CbSwicthTable = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmFoodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmDisCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LsBill);
            this.panel2.Location = new System.Drawing.Point(445, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 277);
            this.panel2.TabIndex = 2;
            // 
            // LsBill
            // 
            this.LsBill.HideSelection = false;
            this.LsBill.Location = new System.Drawing.Point(0, 3);
            this.LsBill.Name = "LsBill";
            this.LsBill.Size = new System.Drawing.Size(337, 271);
            this.LsBill.TabIndex = 0;
            this.LsBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CbSwicthTable);
            this.panel3.Controls.Add(this.BtnSwitchTable);
            this.panel3.Controls.Add(this.NmDisCount);
            this.panel3.Controls.Add(this.BtnDiscount);
            this.panel3.Controls.Add(this.BtnCheckOut);
            this.panel3.Location = new System.Drawing.Point(445, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 62);
            this.panel3.TabIndex = 3;
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.Location = new System.Drawing.Point(254, 3);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(81, 54);
            this.BtnCheckOut.TabIndex = 3;
            this.BtnCheckOut.Text = "Thanh toán";
            this.BtnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NmFoodCount);
            this.panel4.Controls.Add(this.BtnAddFood);
            this.panel4.Controls.Add(this.CbFood);
            this.panel4.Controls.Add(this.CbCategory);
            this.panel4.Location = new System.Drawing.Point(445, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 60);
            this.panel4.TabIndex = 4;
            // 
            // NmFoodCount
            // 
            this.NmFoodCount.Location = new System.Drawing.Point(301, 20);
            this.NmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NmFoodCount.Name = "NmFoodCount";
            this.NmFoodCount.Size = new System.Drawing.Size(37, 22);
            this.NmFoodCount.TabIndex = 3;
            this.NmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnAddFood
            // 
            this.BtnAddFood.Location = new System.Drawing.Point(214, 3);
            this.BtnAddFood.Name = "BtnAddFood";
            this.BtnAddFood.Size = new System.Drawing.Size(81, 54);
            this.BtnAddFood.TabIndex = 2;
            this.BtnAddFood.Text = "Thêm món";
            this.BtnAddFood.UseVisualStyleBackColor = true;
            // 
            // CbFood
            // 
            this.CbFood.FormattingEnabled = true;
            this.CbFood.Location = new System.Drawing.Point(3, 33);
            this.CbFood.Name = "CbFood";
            this.CbFood.Size = new System.Drawing.Size(205, 24);
            this.CbFood.TabIndex = 1;
            // 
            // CbCategory
            // 
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(3, 3);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(205, 24);
            this.CbCategory.TabIndex = 0;
            // 
            // FlpTable
            // 
            this.FlpTable.Location = new System.Drawing.Point(9, 31);
            this.FlpTable.Name = "FlpTable";
            this.FlpTable.Size = new System.Drawing.Size(432, 407);
            this.FlpTable.TabIndex = 5;
            // 
            // BtnDiscount
            // 
            this.BtnDiscount.Location = new System.Drawing.Point(167, 2);
            this.BtnDiscount.Name = "BtnDiscount";
            this.BtnDiscount.Size = new System.Drawing.Size(81, 27);
            this.BtnDiscount.TabIndex = 4;
            this.BtnDiscount.Text = "Giảm giá";
            this.BtnDiscount.UseVisualStyleBackColor = true;
            // 
            // NmDisCount
            // 
            this.NmDisCount.Location = new System.Drawing.Point(167, 35);
            this.NmDisCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NmDisCount.Name = "NmDisCount";
            this.NmDisCount.Size = new System.Drawing.Size(81, 22);
            this.NmDisCount.TabIndex = 5;
            this.NmDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSwitchTable
            // 
            this.BtnSwitchTable.Location = new System.Drawing.Point(3, 3);
            this.BtnSwitchTable.Name = "BtnSwitchTable";
            this.BtnSwitchTable.Size = new System.Drawing.Size(158, 27);
            this.BtnSwitchTable.TabIndex = 6;
            this.BtnSwitchTable.Text = "Chuyển bàn";
            this.BtnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // CbSwicthTable
            // 
            this.CbSwicthTable.FormattingEnabled = true;
            this.CbSwicthTable.Location = new System.Drawing.Point(3, 34);
            this.CbSwicthTable.Name = "CbSwicthTable";
            this.CbSwicthTable.Size = new System.Drawing.Size(158, 24);
            this.CbSwicthTable.TabIndex = 7;
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán coffee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NmFoodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmDisCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView LsBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox CbFood;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.NumericUpDown NmFoodCount;
        private System.Windows.Forms.Button BtnAddFood;
        private System.Windows.Forms.FlowLayoutPanel FlpTable;
        private System.Windows.Forms.Button BtnCheckOut;
        private System.Windows.Forms.NumericUpDown NmDisCount;
        private System.Windows.Forms.Button BtnDiscount;
        private System.Windows.Forms.Button BtnSwitchTable;
        private System.Windows.Forms.ComboBox CbSwicthTable;
    }
}