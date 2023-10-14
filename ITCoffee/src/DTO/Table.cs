using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DTO
{
    internal class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public string NameTableArea { get; set; }
        public Table(int id, string name, string status, string nameTableArea)
        {
            Id = id;
            Name = name;
            Status = status;
            NameTableArea = nameTableArea;
        }
        public Table(DataRow row)
        {
            this.Id = (int)row[0];
            this.Name = (string)row[1];
            this.Status = (string)row[2];
            this.NameTableArea = (string)row["TableAreaName"];
        }
    }
}
