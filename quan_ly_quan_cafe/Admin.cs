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
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFormDate.Value, dtpkToDate.Value);
        }


        void LoadAccountList()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";

            DtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"staff"});
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFormDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFormDate.Value.AddMonths(1).AddDays(-1);
        }

        #region methods
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            DtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        #endregion

        #region event
        private void BtnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFormDate.Value, dtpkToDate.Value);
        }
        #endregion
    }
}
