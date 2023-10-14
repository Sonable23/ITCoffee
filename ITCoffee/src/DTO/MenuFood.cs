using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DTO
{
    internal class MenuFood
    {
        public string foodName { get; set; }
        public int count { get; set; }
        public double price { get; set; }
        public double totalPrice { get; set; }
        public int idFood { get; set; }

        public MenuFood(string foodName, int count, double price, double totalPrice = 0) { 
            this.foodName = foodName;
            this.count = count;
            this.price = price;
            this.totalPrice = totalPrice;
        }
        public MenuFood(DataRow row)
        {
            this.foodName = (string)row["FoodName"];
            this.count = (int)row["Count"];
            this.price = (int)row["FoodPrice"];
            this.totalPrice = (int)row["TotalPrice"];
            this.idFood= (int)row["idFood"];
        }
    }
}
