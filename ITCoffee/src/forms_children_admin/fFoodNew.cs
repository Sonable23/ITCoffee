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
    public partial class fFoodNew : Form
    {
        public delegate void Delegate();
        public Delegate FoodLoad;
        public fFoodNew()
        {
            InitializeComponent();
            loadFoodGroupCombobox();
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
            double foodPrice  = Convert.ToDouble(txt_foodPrice.Text);
            int idFoodCategory = (cb_foodGroup.SelectedItem as FoodCategory).idFoodCategory;
            FoodDAO.getInstance.FoodInsert(foodName, foodPrice, idFoodCategory);

            if(FoodLoad != null) {
                FoodLoad();
                Close();
            }
        }
    }
}
