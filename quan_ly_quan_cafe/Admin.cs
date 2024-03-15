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
        public Admin()
        {
            InitializeComponent();

            LoadAccountList();
            Load();
        }

        void Load()
        {
            DtgvFood.DataSource = foodList;

            LoadListFood();
            LoadCategoryIntoCombobox(CbFoodCategory);
            AddFoodBinding();
        }

        public void LoadAccountList()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";

            DtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"staff"});
        }

        void AddFoodBinding()
        {
            TxbFoodName.DataBindings.Add(new Binding("Text", DtgvFood.DataSource, "Name"));
            TxbFoodID.DataBindings.Add(new Binding("Text", DtgvFood.DataSource, "ID"));
            NmFoodPrice.DataBindings.Add(new Binding("Value", DtgvFood.DataSource, "Price"));
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
    }
}
