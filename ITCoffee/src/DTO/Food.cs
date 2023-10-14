using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DTO
{
    internal class Food
    {
        public int idFood { get; set; }
        public string foodName { get; set; }
        public double foodPrice { get; set; }
        public string categoryName { get; set; }
        public int idcategory { get; set; }



        public Food(DataRow dataRow)
        {
            this.idFood = (int)dataRow["idFood"];
            this.foodName = (string)dataRow["FoodName"];
            this.foodPrice = Convert.ToDouble(dataRow["FoodPrice"]);
            this.idcategory = (int)dataRow["idFoodCategory"];
            this.categoryName = (string)dataRow["CategoryName"];

        }
    }
}
