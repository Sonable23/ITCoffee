using ITCoffee.src.dataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DAO
{
    internal class BillInforDAO
    {
        private static BillInforDAO instance;
        private BillInforDAO() { }
        public static BillInforDAO getInstance
        {
            get
            {
                if (instance == null) { instance = new BillInforDAO(); }
                return instance;
            }
        }
        public int InsertBillInfor(int idBill, int idFood)
        {
            int res = DataProvider.Instance.ExcuteNonQuery($"USP_BillInfoInsert {idBill} , {idFood}");
            return res;
        }
        public int UpdateCountBillInfor(int idBill, int idFood, int count)
        {
        int res = DataProvider.Instance.ExcuteNonQuery($"USP_BillInfoInsert {idBill} , {idFood} , {count}");
            return res;
        }
    }
}
