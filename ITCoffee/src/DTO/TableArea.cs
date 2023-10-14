using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DTO
{
    internal class TableArea
    {
        public int idTableArea { get; set; }
        public string nameTableArea { get; set; }
        public TableArea (int idTableName, string nameTableArea)
        {
            this.idTableArea = idTableName;
            this.nameTableArea = nameTableArea;
        }
        public TableArea(DataRow row)
        {
            this.idTableArea = (int)row[0];
            this.nameTableArea = (string)row[1];
        }
    }
}
