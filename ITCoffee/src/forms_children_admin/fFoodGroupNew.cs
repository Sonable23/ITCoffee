using ITCoffee.src.DAO;
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
    public partial class fFoodGroupNew : Form
    {
        public delegate void Delegate();
        public Delegate FoodGroupLoad;
        public fFoodGroupNew()
        {
            InitializeComponent();
        }

        private void btn_saveFoodGroup_Click(object sender, EventArgs e)
        {
            if(txt_foodGroup.Text.Length > 0)
            {
                FoodCategoryDAO.getInstance.FoodGroupInsert(txt_foodGroup.Text);
                fAdmin admin = new fAdmin();
                if(FoodGroupLoad != null)
                {
                    FoodGroupLoad();
                }
            }
        }
    }
}
