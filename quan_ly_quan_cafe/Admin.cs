using quan_ly_quan_cafe.DAO;
using quan_ly_quan_cafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_quan_cafe
{
    public partial class Admin : Form
    {
        BindingSource foodList = new BindingSource();

        BindingSource accountList = new BindingSource();

        public Account loginAccount;

        public Admin()
        {
            InitializeComponent();
            LoadData();
        }

        #region method
        void LoadData()
        {
            DtgvFood.DataSource = foodList;
            DtgvAccount.DataSource = accountList;

            LoadListFood();
            LoadAccount();
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFormDate.Value, dtpkToDate.Value);
            LoadCategoryIntoCombobox(CbFoodCategory);
            AddFoodBinding();
            AddAccountBinding();
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFormDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFormDate.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            DtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        void AddAccountBinding()
        {
            TxbUserName.DataBindings.Add(new Binding("Text", DtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            TxbDisplayName.DataBindings.Add(new Binding("Text", DtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            ChooseTypeAccount.DataBindings.Add(new Binding("Value", DtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        public void LoadAccountList()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";

            DtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"staff"});
        }

        void AddFoodBinding()
        {
            TxbFoodName.DataBindings.Add(new Binding("Text", DtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            TxbFoodID.DataBindings.Add(new Binding("Text", DtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            NmFoodPrice.DataBindings.Add(new Binding("Value", DtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadListFood()
        {
           foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }

        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!");
            }

            LoadAccount();
        }

        void UpdateAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại!");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName)) {
                MessageBox.Show("Bạn không thể xóa tài khoản của mình!");
                return;
            }

            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!");
            }

            LoadAccount();
        }

        void ResetPassword(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại!");
            }
        }

        #endregion

        #region event
        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = TxbUserName.Text;
            string displayName = TxbDisplayName.Text;
            int type = (int)ChooseTypeAccount.Value;

            AddAccount(userName, displayName, type);
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = TxbUserName.Text;

            DeleteAccount(userName);
        }

        private void BtnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = TxbUserName.Text;
            string displayName = TxbDisplayName.Text;
            int type = (int)ChooseTypeAccount.Value;

            UpdateAccount(userName, displayName, type);
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = TxbUserName.Text;

            ResetPassword(userName);
        }

        private void BtnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void TxbFoodID_TextChanged(object sender, EventArgs e)
        {
            if (DtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)DtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                CbFoodCategory.SelectedItem = cateogory;

                int index = -1;
                int i = 0;
                foreach (Category item in CbFoodCategory.Items)
                {
                    if (item.ID == cateogory.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                CbFoodCategory.SelectedIndex = index;
            }
        }

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            string name = TxbFoodName.Text;
            int categoryID = (CbFoodCategory.SelectedItem as Category).ID;
            float price = (float)NmFoodPrice.Value;
            
            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi thêm thức ăn");
            }
        }

        private void BtnEditFood_Click(object sender, EventArgs e)
        {
            string name = TxbFoodName.Text;
            int categoryID = (CbFoodCategory.SelectedItem as Category).ID;
            float price = (float)NmFoodPrice.Value;
            int id = Convert.ToInt32(TxbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void BtnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxbFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }

        private void BtnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(TxbSearchFoodName.Text);
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        #endregion
    }
}
