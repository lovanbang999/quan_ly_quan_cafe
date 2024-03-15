using quan_ly_quan_cafe.DAO;
using quan_ly_quan_cafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_quan_cafe
{
    public partial class TableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public TableManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            LoadTable();
            LoadCategory();
            LoadComboboxTable(CbSwicthTable);
        }

        #region Method

        // hthi categoty
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            CbCategory.DataSource = listCategory;
            CbCategory.DisplayMember = "Name";
        }
        // hthi food
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            CbFood.DataSource = listFood;
            CbFood.DisplayMember = "Name";
        }

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + loginAccount.DisplayName + ")";
        }

        void LoadTable()
        {
            FlpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();
            // them button vao fplTable
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click; ;
                btn.Tag = item;

                // hieu ung ban trong 
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                FlpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            LsBill.Items.Clear();
            List<quan_ly_quan_cafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (quan_ly_quan_cafe.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                // tinh tong tien
                totalPrice += item.TotalPrice;
                LsBill.Items.Add(lsvItem);
            }
            // conver total VN
            CultureInfo culture = new CultureInfo("vi-VN");
            TxbTotalPrice.Text = totalPrice.ToString("c", culture);
        }
        void LoadComboboxTable(ComboBox cb) 
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        #endregion

        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            LsBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile f = new AccountProfile(loginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.ShowDialog();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) { return; }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);

        }

        // them mon an vao hoa don
        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            Table table = LsBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (CbFood.SelectedItem as Food).Id;
            int count = (int)NmFoodCount.Value;

            if (idBill == -1)
            {
                // them bill moi
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);

            LoadTable();
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = LsBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)NmDisCount.Value;
            // can xu li lai
            double totalPrice = Convert.ToDouble(TxbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount);
                    ShowBill(table.ID);

                    LoadTable();
                }
            }
        }
        // button chuyen ban
        private void BtnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (LsBill.Tag as Table).ID;

            int id2 = (CbSwicthTable.SelectedItem as Table).ID;

            if (MessageBox.Show(string.Format("Bạn có thực sự muốn chuyển bàn {0} qua bàn {1}", (LsBill.Tag as Table).Name, (CbSwicthTable.SelectedItem as Table).Name), "Thông báo",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK);
            {
                TableDAO.Instance.SwitchTable(id1,id2);
            }

            LoadTable();
        }
    }
    #endregion
}
