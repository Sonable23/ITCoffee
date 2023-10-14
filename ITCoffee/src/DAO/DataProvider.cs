using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.dataProvider
{
    internal class DataProvider
    {
        private static DataProvider instance;
        private DataProvider() { }
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }
       
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable table = new DataTable();
            string connectionStr = @"Data Source=HAIRSONWLAPTOP\HAISON;Initial Catalog=ITCoffee;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionStr)) { 
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
              
                if (parameter != null)
                {
                    //mảng object chứa chuỗi query
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    //duyệt mảng để tìm ra các item chứ kí tự @
                    foreach(string item in listPara) { 
                        //nếu tìm thấy thì add item đó vào parameter of command

                        if(item.Contains('@'))
                        {
                            //parameter[i] là item value đối số truyền vào khi gọi hàm ExcuteQuey(query, parameter[])
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }
            return table;
        }
        
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            string connectionStr = "Data Source=HAIRSONWLAPTOP\\HAISON;Initial Catalog=ITCoffee;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    //mảng object chứa chuỗi query
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    //duyệt mảng để tìm ra các item chứ kí tự @
                    foreach (string item in listPara)
                    {
                        //nếu tìm thấy thì add item đó và value vào parameter of command
                        if (item.Contains('@'))
                        {
                            //parameter[i] là item value đối số truyền vào khi gọi hàm ExcuteQuey(query, parameter[])
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        
        public object ExcuteScarlar(string query, object[] parameter = null)
        {
            object data = null;
            string connectionStr = "Data Source=HAIRSONWLAPTOP\\HAISON;Initial Catalog=ITCoffee;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    //mảng object chứa chuỗi query
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    //duyệt mảng để tìm ra các item chứ kí tự @
                    foreach (string item in listPara)
                    {
                        //nếu tìm thấy thì add item đó và value vào parameter of command
                        if (item.Contains('@'))
                        {
                            //parameter[i] là item value đối số truyền vào khi gọi hàm ExcuteQuey(query, parameter[])
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
