using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DTO
{
    public class BillInfor
    {
        public int idBillInfor { get;set; }
        public int idBill { get; set; }
        public int idFood { get; set; }
        public int Count { get; set; }

        public BillInfor(DataRow row)
        {
            this.idBillInfor = (int)row[0];
            this.idBill = (int)row[1];
            this.idFood = (int)row[2];
            this.Count = (int)row[3];
        }
    }
}
