using ITCoffee.src.dataProvider;
using ITCoffee.src.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DAO
{
    internal class StaffDAO
    {
        private static StaffDAO instance = null;

        private StaffDAO() { }
        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StaffDAO();
                }
                return instance;
            }

        }
        public List<Staff> StaffGetList()
        {
            List<Staff> list = new List<Staff>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_StaffGetList");
            foreach (DataRow row in data.Rows) {
                Staff staff = new Staff(row);
                list.Add(staff);
            }
            return list;
        }
        public int StaffInsert(string name, int phone, int cmnd, string address, string position, double salaryBasic)
        {
            string query = "USP_StaffInsert @name , @phone , @cmnd , @address , @position , @salaryBasic ";
            object[] parameter = new object[] {name, phone, cmnd, address, position, salaryBasic };
            return DataProvider.Instance.ExcuteNonQuery(query, parameter);
        }
        public int StaffUpdate(int idStaff, string name, int phone, int cmnd, string address, string position, double salaryBasic)
        {
            string query = "USP_StaffUpdate @idStaff , @name , @phone , @cmnd , @address , @position , @salaryBasic ";
            object[] parameter = new object[] { idStaff, name, phone, cmnd, address, position, salaryBasic };
            return DataProvider.Instance.ExcuteNonQuery(query, parameter);
        }
        public int StaffDelete(int idStaff)
        {
            string query = "USP_StaffDelete @idStaff";
            object[] parameter = new object[] { idStaff };
            return DataProvider.Instance.ExcuteNonQuery(query, parameter);
        }
    }
}
