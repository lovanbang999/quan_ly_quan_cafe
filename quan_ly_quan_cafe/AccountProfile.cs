using quan_ly_quan_cafe.DAO;
using quan_ly_quan_cafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_quan_cafe
{
    public partial class AccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public AccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            TxbUserName.Text = LoginAccount.UserName;
            TxbDisplayName.Text = LoginAccount.DisplayName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void UpdateAccountInfor()
        {
            string displayName = TxbDisplayName.Text;
            string userName = TxbUserName.Text;
            string password = TxbPassWord.Text;
            string newPassword = TxbNewPassWord.Text;
            string reEnterPassword = TxbReEnterPass.Text;

            if (!newPassword.Equals(reEnterPassword))
            {
                MessageBox.Show("Mật khẩu mới không khớp với nhau!");
            } else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newPassword))
                {
                    MessageBox.Show("Cập nhật thành thông!");
                    if (updateAccount !=  null)
                    {
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                    }
                } else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu!");
                }
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfor();
        }
    }

    public class AccountEvent : EventArgs
    {
        private Account acc;

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }

        public Account Acc { get => acc; set => acc = value; }
    }
}
