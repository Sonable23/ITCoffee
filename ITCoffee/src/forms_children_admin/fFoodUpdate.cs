using ITCoffee.src.DAO;
using ITCoffee.src.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCoffee.src.forms_children_admin
{
    public partial class fFoodUpdate : Form
    {
        public delegate void Delegate();
        public Delegate FoodLoad;
        private int _idFood;

        public fFoodUpdate(int idFood ,string foodName, double foodPrice ,string foodCategoryName)
        {
            InitializeComponent();
            loadFoodGroupCombobox();
            txt_foodName.Text = foodName;
            txt_foodPrice.Text =  foodPrice.ToString();
            cb_foodGroup.Text = foodCategoryName;
            this._idFood = idFood;
        }
        public void loadFoodGroupCombobox()
        {
            List<FoodCategory> foodGroupList = FoodCategoryDAO.getInstance.getListFoodCategory();

            cb_foodGroup.DataSource = foodGroupList;
            cb_foodGroup.DisplayMember = "categoryName";
        }

        private void btn_foodSave_Click(object sender, EventArgs e)
        {
            string foodName = txt_foodName.Text;
            double foodPrice = Convert.ToDouble(txt_foodPrice.Text);
            int idFoodCategoryName = (cb_foodGroup.SelectedItem as FoodCategory).idFoodCategory;
            
            FoodDAO.getInstance.FoodUpdate(_idFood, foodName, foodPrice, idFoodCategoryName);
            fAdmin admin = new fAdmin();
            if(FoodLoad !=  null)
            {
                FoodLoad();
                Close();
            }
        }
    }
}
