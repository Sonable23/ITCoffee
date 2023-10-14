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
    internal class MenuFoodDAO
    {
        private static MenuFoodDAO instance;
        private MenuFoodDAO() { }

        public static MenuFoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuFoodDAO();
                }
                return instance;
            }
        }
        public List<MenuFood> MenuList(int tableId)
        {
            List<MenuFood> menuList = new List<MenuFood>();
            string query = "USP_MenuGetList @idTable";
            object[] parameter = new object[] { tableId };
            DataTable data = DataProvider.Instance.ExcuteQuery(query, parameter);
            foreach (DataRow row in data.Rows)
            {
                MenuFood menu = new MenuFood(row);
                menuList.Add(menu);
            }
            return menuList;
        }
    }
}
