namespace quan_ly_quan_cafe
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LsBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxbTotalPrice = new System.Windows.Forms.TextBox();
            this.CbSwicthTable = new System.Windows.Forms.ComboBox();
            this.BtnSwitchTable = new System.Windows.Forms.Button();
            this.NmDisCount = new System.Windows.Forms.NumericUpDown();
            this.BtnDiscount = new System.Windows.Forms.Button();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.BtnAddFood = new System.Windows.Forms.Button();
            this.CbFood = new System.Windows.Forms.ComboBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.FlpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmDisCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmFoodCount)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1017, 28);
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
            this.PersonalInformationToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // PersonalInformationToolStripMenuItem
            // 
            this.PersonalInformationToolStripMenuItem.Name = "PersonalInformationToolStripMenuItem";
            this.PersonalInformationToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.PersonalInformationToolStripMenuItem.Text = "Thông tin cá nhân";
            this.PersonalInformationToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.LogOutToolStripMenuItem.Text = "Đăng xuất";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LsBill);
            this.panel2.Location = new System.Drawing.Point(589, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 280);
            this.panel2.TabIndex = 2;
            // 
            // LsBill
            // 
            this.LsBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsBill.GridLines = true;
            this.LsBill.HideSelection = false;
            this.LsBill.Location = new System.Drawing.Point(0, 3);
            this.LsBill.Name = "LsBill";
            this.LsBill.Size = new System.Drawing.Size(425, 271);
            this.LsBill.TabIndex = 0;
            this.LsBill.UseCompatibleStateImageBehavior = false;
            this.LsBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 66;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 80;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxbTotalPrice);
            this.panel3.Controls.Add(this.CbSwicthTable);
            this.panel3.Controls.Add(this.BtnSwitchTable);
            this.panel3.Controls.Add(this.NmDisCount);
            this.panel3.Controls.Add(this.BtnDiscount);
            this.panel3.Controls.Add(this.BtnCheckOut);
            this.panel3.Location = new System.Drawing.Point(589, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 62);
            this.panel3.TabIndex = 3;
            // 
            // TxbTotalPrice
            // 
            this.TxbTotalPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.TxbTotalPrice.Location = new System.Drawing.Point(198, 15);
            this.TxbTotalPrice.Name = "TxbTotalPrice";
            this.TxbTotalPrice.ReadOnly = true;
            this.TxbTotalPrice.Size = new System.Drawing.Size(137, 28);
            this.TxbTotalPrice.TabIndex = 8;
            this.TxbTotalPrice.Text = "0";
            this.TxbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CbSwicthTable
            // 
            this.CbSwicthTable.FormattingEnabled = true;
            this.CbSwicthTable.Location = new System.Drawing.Point(3, 34);
            this.CbSwicthTable.Name = "CbSwicthTable";
            this.CbSwicthTable.Size = new System.Drawing.Size(88, 24);
            this.CbSwicthTable.TabIndex = 7;
            // 
            // BtnSwitchTable
            // 
            this.BtnSwitchTable.Location = new System.Drawing.Point(3, 3);
            this.BtnSwitchTable.Name = "BtnSwitchTable";
            this.BtnSwitchTable.Size = new System.Drawing.Size(88, 27);
            this.BtnSwitchTable.TabIndex = 6;
            this.BtnSwitchTable.Text = "Chuyển bàn";
            this.BtnSwitchTable.UseVisualStyleBackColor = true;
            this.BtnSwitchTable.Click += new System.EventHandler(this.BtnSwitchTable_Click);
            // 
            // NmDisCount
            // 
            this.NmDisCount.Location = new System.Drawing.Point(97, 35);
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
            // BtnDiscount
            // 
            this.BtnDiscount.Location = new System.Drawing.Point(97, 3);
            this.BtnDiscount.Name = "BtnDiscount";
            this.BtnDiscount.Size = new System.Drawing.Size(81, 27);
            this.BtnDiscount.TabIndex = 4;
            this.BtnDiscount.Text = "Giảm giá";
            this.BtnDiscount.UseVisualStyleBackColor = true;
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.Location = new System.Drawing.Point(342, 3);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(74, 54);
            this.BtnCheckOut.TabIndex = 3;
            this.BtnCheckOut.Text = "Thanh toán";
            this.BtnCheckOut.UseVisualStyleBackColor = true;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NmFoodCount);
            this.panel4.Controls.Add(this.BtnAddFood);
            this.panel4.Controls.Add(this.CbFood);
            this.panel4.Controls.Add(this.CbCategory);
            this.panel4.Location = new System.Drawing.Point(589, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 60);
            this.panel4.TabIndex = 4;
            // 
            // NmFoodCount
            // 
            this.NmFoodCount.Location = new System.Drawing.Point(358, 20);
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
            this.BtnAddFood.Location = new System.Drawing.Point(241, 3);
            this.BtnAddFood.Name = "BtnAddFood";
            this.BtnAddFood.Size = new System.Drawing.Size(94, 54);
            this.BtnAddFood.TabIndex = 2;
            this.BtnAddFood.Text = "Thêm món";
            this.BtnAddFood.UseVisualStyleBackColor = true;
            this.BtnAddFood.Click += new System.EventHandler(this.BtnAddFood_Click);
            // 
            // CbFood
            // 
            this.CbFood.FormattingEnabled = true;
            this.CbFood.Location = new System.Drawing.Point(3, 33);
            this.CbFood.Name = "CbFood";
            this.CbFood.Size = new System.Drawing.Size(232, 24);
            this.CbFood.TabIndex = 1;
            // 
            // CbCategory
            // 
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(3, 3);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(232, 24);
            this.CbCategory.TabIndex = 0;
            this.CbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // FlpTable
            // 
            this.FlpTable.AutoScroll = true;
            this.FlpTable.Location = new System.Drawing.Point(0, 30);
            this.FlpTable.Name = "FlpTable";
            this.FlpTable.Size = new System.Drawing.Size(589, 407);
            this.FlpTable.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 439);
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
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmDisCount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NmFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PersonalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox TxbTotalPrice;
    }
}