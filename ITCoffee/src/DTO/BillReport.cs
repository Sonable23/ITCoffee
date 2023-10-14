using ITCoffee.src.dataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DTO
{
    public class BillReport
    {
        public int idBill { get; set; }
        public string tableName { get; set; }
        public DateTime? dataCheckIn { get; set; }
        public DateTime? dataCheckOut { get; set; }
        public string messageBill { get; set; }
        public double totalPrice { get; set; }

        public BillReport(DataRow row)
        {
            this.idBill = (int)row["idBill"];
            this.dataCheckIn = (DateTime?)(row["DataCheckIn"]);
            this.dataCheckOut = row["DataCheckOut"] != DBNull.Value ? (DateTime?)row["DataCheckOut"] : null;
            this.messageBill = (string)row["MessageBill"];
            this.tableName = (string)row["TableName"];
            this.totalPrice = Convert.ToInt32(row["TotalPrice"]);
        }
    }
}
