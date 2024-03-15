using quan_ly_quan_cafe.DAO;
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
        public Admin()
        {
            InitializeComponent();

            LoadAccountList();
            Load();
        }

        void Load()
        {
            LoadListFood();
        }

        public void LoadAccountList()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";

            DtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"staff"});
        }

        void LoadListFood()
        {
            DtgvFood.DataSource = FoodDAO.Instance.GetListFood();
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
    }
}
