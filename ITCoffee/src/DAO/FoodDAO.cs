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
    internal class FoodDAO
    {
        private static FoodDAO instance;
        private FoodDAO() { }
        public static FoodDAO getInstance
        {
            get {
                if (instance == null)
                {
                    instance = new FoodDAO();
                }
                return instance;
            }
        }
        public List<Food> getListFoodByIdCategory(int? idCategory = null)
        {
            List<Food> listFood = new List<Food>();
            string query = "USP_FoodCategoryGetListById @IdCategory";
            object[] parameter = new object[] { idCategory }; 
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query, parameter);
            foreach (DataRow row in dataTable.Rows)
            {
                Food food = new Food(row);
                listFood.Add(food);
            }
            return listFood;
        }
        public List<Food> getListFoodByName(string foodName)
        {
            List<Food> listFood = new List<Food>();
            string query = "USP_FoodSearchByName @FoodName";
            object[] parameter = new object[] { foodName };
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query, parameter);
            foreach (DataRow row in dataTable.Rows)
            {
                Food food = new Food(row);
                listFood.Add(food);
            }
            return listFood;
        }
        public List<Food> FoodGetListAll()
        {
            List<Food> listFood = new List<Food>();
            string query = "USP_FoodGetList";
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                Food food = new Food(row);
                listFood.Add(food);
            }
            return listFood;
        }
        public int FoodInsert(string foodName, double foodPrice, int idFoodCategory)
        {
            object[] parameter = new object[] { foodName, foodPrice, idFoodCategory };
            string query = "USP_FoodInsert @foodName , @foodPrice , @idFoodCategory ";
            return DataProvider.Instance.ExcuteNonQuery(query, parameter);
        }
        public int FoodUpdate(int idFood,string foodName, double foodPrice, int idFoodCategory)
        {
            object[] parameter = new object[] { idFood , foodName, foodPrice, idFoodCategory };
            string query = "USP_FoodUpdateInfo @idFood , @foodName , @foodPrice , @idFoodCategory ";
            return DataProvider.Instance.ExcuteNonQuery(query, parameter);
        }
        public int FoodDeleteId(int idFood)
        {
            string query = "USP_FoodDeleteId @idFood";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { idFood });
        }
    }
}
