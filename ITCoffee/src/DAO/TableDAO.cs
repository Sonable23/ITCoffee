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
    internal class TableDAO
    {
        private static TableDAO instance;
        private TableDAO() { }
        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TableDAO();
                }
                return instance;
            }
        }

        public List<Table> tableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("USP_TableGetList");
            foreach (DataRow row in dataTable.Rows)
            {
                Table table = new Table(row);
                tableList.Add(table);
            }
            return tableList;
        }
        public int handleTableSwitch(int idTable1, int idTable2)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_TableSwitch @idTable1 , @idTable2", new object[] { idTable1, idTable2 });
        }
        public List<TableArea> tableAreaList()
        {
            List<TableArea> tableList = new List<TableArea>();
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("USP_TableAreaGetList");
            foreach (DataRow row in dataTable.Rows)
            {
                TableArea table = new TableArea(row);
                tableList.Add(table);
            }
            return tableList;
        }
        //add table
        public int TableInsert(string tableName, int idTableArea)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_TableInsert @tableName , @idTableArea", new object[] { tableName, idTableArea });
        }
        // update tables
        public int TableUpdate(int idTable, string tableName, int idTableArea)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_TableUpdate @idTable , @tableName , @idTableArea", new object[] { idTable, tableName, idTableArea });
        }
        //delete table
        public int DeleteTable(int idTable)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_TableDeleteId @idTable", new object[] { idTable });
        }
        //Insert table area
        public int TableAreaInsert(string tableAreaName)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_TableAreaInsert @tableAreaName ", new object[] { tableAreaName });
        }
        //Update table area
        public int TableAreaUpdate(int idTableArea, string tableAreaName)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_TableAreaUpdate @idTable , @tableAreaName", new object[] { idTableArea, tableAreaName });
        }
        //Delete table area
        public int TableAreaDeleteById(int idTableArea)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_TableAreaDeleteById @idTable ", new object[] { idTableArea });
        }
    }
}
