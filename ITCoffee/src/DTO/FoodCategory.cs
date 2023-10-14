using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCoffee.src.DTO
{
    internal class FoodCategory
    {
        public int idFoodCategory { get; set; }
        public string categoryName { get; set; }
      

        public FoodCategory(int idFoodCategory, string categoryName)
        {
            this.idFoodCategory = idFoodCategory;
            this.categoryName = categoryName;
          
        }
        public FoodCategory(DataRow dataRow) {
            this.idFoodCategory = (int)dataRow[0];
            this.categoryName = (string)dataRow[1];   
        }
    }
}
