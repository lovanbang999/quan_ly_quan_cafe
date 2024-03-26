namespace quan_ly_quan_cafe
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxbPassWord = new System.Windows.Forms.TextBox();
            this.LbPassWord = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxbUserName = new System.Windows.Forms.TextBox();
            this.LbUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 197);
            this.panel1.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(533, 154);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(113, 30);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(394, 154);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(113, 30);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Đăng nhập";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxbPassWord);
            this.panel3.Controls.Add(this.LbPassWord);
            this.panel3.Location = new System.Drawing.Point(6, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 68);
            this.panel3.TabIndex = 1;
            // 
            // TxbPassWord
            // 
            this.TxbPassWord.Location = new System.Drawing.Point(190, 23);
            this.TxbPassWord.Name = "TxbPassWord";
            this.TxbPassWord.Size = new System.Drawing.Size(434, 22);
            this.TxbPassWord.TabIndex = 1;
            this.TxbPassWord.UseSystemPasswordChar = true;
            // 
            // LbPassWord
            // 
            this.LbPassWord.AutoSize = true;
            this.LbPassWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassWord.Location = new System.Drawing.Point(13, 23);
            this.LbPassWord.Name = "LbPassWord";
            this.LbPassWord.Size = new System.Drawing.Size(104, 24);
            this.LbPassWord.TabIndex = 0;
            this.LbPassWord.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxbUserName);
            this.panel2.Controls.Add(this.LbUserName);
            this.panel2.Location = new System.Drawing.Point(6, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 68);
            this.panel2.TabIndex = 0;
            // 
            // TxbUserName
            // 
            this.TxbUserName.Location = new System.Drawing.Point(190, 25);
            this.TxbUserName.Name = "TxbUserName";
            this.TxbUserName.Size = new System.Drawing.Size(434, 22);
            this.TxbUserName.TabIndex = 1;
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserName.Location = new System.Drawing.Point(13, 23);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(159, 24);
            this.LbUserName.TabIndex = 0;
            this.LbUserName.Text = "Tên đăng nhập:";
            // 
            // Login
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(671, 216);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxbPassWord;
        private System.Windows.Forms.Label LbPassWord;
        private System.Windows.Forms.TextBox TxbUserName;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLogin;
    }
}

