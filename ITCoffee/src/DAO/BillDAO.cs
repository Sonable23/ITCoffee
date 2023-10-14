using ITCoffee.src.dataProvider;
using ITCoffee.src.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;
        private BillDAO() { }
        public static BillDAO getInstance
        {
            get
            {
                if (instance == null) { instance = new BillDAO(); }
                return instance;
            }
        }


        public int GetUncheckBillByTableId(int idTable)
        {
            string query = $"USP_BillGetUnCheckByTableId {idTable}";
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            if (dataTable.Rows.Count > 0)
            {
                Bill bill = new Bill(dataTable.Rows[0]);
                return bill.idBill;
            }
            return -1;
        }
        public int InsertBill(int idTable)
        {
            string query = "USP_BillInsert @idTable";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { idTable });
        }
        public int BillCheckOut(int idBill)
        {
            string query = "USP_BillCheckOut @idBill";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { idBill });
        }
        public int DeleteBill(int idBill)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_BillDeleteId @idBill", new object[] { idBill });
        }
        public List<BillHistory> BillHistory()
        {
            List<BillHistory> listBillHistory = new List<BillHistory>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("USP_BillHistory");
            foreach (DataRow row in dataTable.Rows)
            {
                BillHistory bill = new BillHistory(row);
                listBillHistory.Add(bill);
            }

            return listBillHistory;
        }
        public List<BillReport> BillReport()
        {
            List<BillReport> listBillReport = new List<BillReport>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("USP_BillReport");
            foreach (DataRow row in dataTable.Rows)
            {
                BillReport bill = new BillReport(row);
                listBillReport.Add(bill);
            }

            return listBillReport;
        }
    }

}
