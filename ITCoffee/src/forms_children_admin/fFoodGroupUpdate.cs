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
    public partial class fFoodGroupUpdate : Form
    {
        public delegate void Delegate();
        public Delegate FoodGroupLoad;
        private int _idFoodGroup;
        public fFoodGroupUpdate(int idFoodGroup, string foodGroupName)
        {
            InitializeComponent();
            txt_foodGroup.Text = foodGroupName;
            _idFoodGroup = idFoodGroup;
        }
        private void btn_saveFoodGroup_Click(object sender, EventArgs e)
        {
            if (txt_foodGroup.Text.Length > 0)
            {
                FoodCategoryDAO.getInstance.FoodGroupUpdate(_idFoodGroup,txt_foodGroup.Text);
                fAdmin admin = new fAdmin();
                if(FoodGroupLoad != null)
                {

                    FoodGroupLoad();
                    Close();
                }
            }
        }
    }
}
