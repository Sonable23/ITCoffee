using ITCoffee.src.dataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;
        private AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }
        public bool Login(string username, string password)
        {
            string query = @"USP_AccountLogin @Username , @Password";
            object[] parameter = new object[] { username, password };
            DataTable result = DataProvider.Instance.ExcuteQuery(query, parameter);
            return result.Rows.Count > 0;
        }
        public int Create(string username, string password, string email)
        {
            string query = @"USP_AccountCreate @Username , @Password , email";
            object[] parameter = new object[] { username, password, email };
            return DataProvider.Instance.ExcuteNonQuery(query, parameter);
        }

        public int ChangPassword(string username, string passwordOld, string passwordNew)
        {
            string query = @"USP_AccountChangePassword @Username , @PasswordOld , @PasswordNew";
            object[] parameter = new object[] { username, passwordOld, passwordNew };
            return DataProvider.Instance.ExcuteNonQuery(query, parameter);
        }
    }
}
