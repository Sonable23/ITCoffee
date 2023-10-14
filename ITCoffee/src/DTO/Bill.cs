using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DTO
{
    internal class Bill
    {
        public int idBill { get; set; }
        public DateTime? DataCheckIn { get; set; }
        public DateTime? DataCheckOut { get; set; }
        public int BillStatus { get; set; }
        public int idTable { get; set; }
        public string messageBill { get; set; }

        public string tableName { get; set; }
        public Bill(DataRow row)
        {
            this.idBill = (int)row["idBill"];
            this.DataCheckIn = (DateTime?)(row["DataCheckIn"]);
            this.DataCheckOut = row["DataCheckOut"] != DBNull.Value ? (DateTime?)row["DataCheckOut"] : null;
            this.BillStatus = (int)row["BillStatus"];
            this.idTable = (int)row["idTable"];
        }

    }
}
