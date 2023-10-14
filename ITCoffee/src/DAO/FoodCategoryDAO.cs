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
    internal class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;
        private FoodCategoryDAO() { }
        public static FoodCategoryDAO getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodCategoryDAO();
                }
                return instance;
            }
        }
        public List<FoodCategory> getListFoodCategory()
        {
            List<FoodCategory > listFoodCategory = new List<FoodCategory>();
            string query = "USP_FoodCategoryGetList";
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                FoodCategory foodCategory = new FoodCategory(row);
                listFoodCategory.Add(foodCategory);
            }
            return listFoodCategory;
        }
        public int FoodGroupInsert(string foodGroupName)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_FoodCategoryInsert @tableAreaName ", new object[] { foodGroupName });
        }
        public int FoodGroupUpdate(int idFoodGroup, string foodGroupName)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_FoodCategoryUpdate @idFoodGroup , @tableAreaName ", new object[] { idFoodGroup,foodGroupName });
        }
        public int FoodGroupDelete(int idFoodGroup)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_FoodCategoryDeleteById @idFoodGroup ", new object[] { idFoodGroup });
        }
    }
}
