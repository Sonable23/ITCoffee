using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DTO
{
    internal class Staff
    {
        public int id { get; set; }
        public string name { get; set; }
        public int phone { get; set; }
        public int cmnd { get; set; }
        public string address { get; set; }
        public string postion { get; set; }
        public double salarybasic { get; set; }
        public DateTime? dayCheckIn { get; set; }
        public DateTime? dayCheckOut { get; set; }
        public Staff(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = (string)row["NameUsers"];
            this.phone = (int)row["Phone"];
            this.cmnd = (int)row["Cmnd"];
            this.address = (string)row["Address"];
            this.postion = (string)row["Position"];
            this.salarybasic =  Convert.ToDouble(row["SalaryBasic"]);
            this.dayCheckIn =  row["DayCheckIn"] != DBNull.Value ? (DateTime?)row["DayCheckIn"] : null;
            this.dayCheckOut = row["DayCheckOut"] != DBNull.Value ? (DateTime?)row["DayCheckOut"] : null;

        }
    }
}
