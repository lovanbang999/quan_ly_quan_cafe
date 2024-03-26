using quan_ly_quan_cafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_quan_cafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        // tinh dong goi 
        public static TableDAO Instance
        {
            get
            {
                if (instance == null) instance = new TableDAO();
                return instance;
            }
            private set { instance = value; }
        }
        // chieu dai va rong button
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        private TableDAO() { }

       // thay doi id table
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }

        // Chuyen trang thai ban
        public bool chageStatusTable(int id)
        {
            string query = string.Format("UPDATE dbo.TableFood SET status = N'Trống' WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            // khoi tao danh sach ban
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public bool InsertTable(string name)
        {
            string query = string.Format("INSERT INTO dbo.TableFood ( name )VALUES  ( N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteTable(int id)
        {
            string query = string.Format("DELETE dbo.TableFood WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTable(int id, string name)
        {
            string query = string.Format("UPDATE dbo.TableFood SET name = N'{0}' WHERE id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
