using QuanLiQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance;}
            private set { TableDAO.instance = value; } 
        }
        private TableDAO() { }

        public static int TableWidth = 100;
        public static int TableHeight = 100;

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }

        public List<Table> GetListTable()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow row in data.Rows)
            {
                Table table = new Table(row);
                tableList.Add(table);
            }

            return tableList;
        }

        public bool InsertTableFood(string name, string status)
        {
            string query = string.Format("insert dbo.TableFood (name , status ) values (N'{0}', N'{1}')",name, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTableFood(int id, string name, string status)
        {
            string query = string.Format("update dbo.TableFood set name = N'{0}', status = N'{1}' where id = {3}",name, status, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
