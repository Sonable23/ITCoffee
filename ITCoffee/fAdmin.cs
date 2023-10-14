using ITCoffee.src.DAO;
using ITCoffee.src.DTO;
using ITCoffee.src.forms_children_admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCoffee
{
    public partial class fAdmin : Form
    {
        //
        private int _idTable;
        private string _nameTable;
        //
        private int _idFood;
        private string _foodName;
        private double _foodPrice;
        private string _foodCategoryName;
        //
        private int _idTableArea;
        private string _nameTableArea;
        public fAdmin()
        {
            InitializeComponent();
            TableLoad();
            FoodLoad();
            TableAreaLoad();
            FoodGroupLoad();
            StaffLoad();
            loadTableaAreaListCombobox();

        }

        public void TableLoad()
        {
            List<Table> tableList = TableDAO.Instance.tableList();
            lv_table.Items.Clear();
            foreach (var table in tableList)
            {
                ListViewItem LvTableItem = new ListViewItem(table.Name);
                LvTableItem.SubItems.Add(table.Status.ToString());
                LvTableItem.SubItems.Add(table.NameTableArea.ToString());
                LvTableItem.Tag = table.Id;

                lv_table.Items.Add(LvTableItem);
            }
        }
        public void TableAreaLoad()
        {
            List<TableArea> tableAreaList = TableDAO.Instance.tableAreaList();
            lv_areaTable.Items.Clear();
            foreach (var item in tableAreaList)
            {
                ListViewItem LvAreaItem = new ListViewItem(item.nameTableArea);
                LvAreaItem.Tag = item.idTableArea;
                lv_areaTable.Items.Add(LvAreaItem);
            }
        }
        public void FoodLoad()
        {

            List<Food> foodList = FoodDAO.getInstance.FoodGetListAll();
            lv_food.Items.Clear();
            foreach (var food in foodList)
            {
                ListViewItem LvFoodItem = new ListViewItem(food.foodName);
                LvFoodItem.SubItems.Add(food.foodPrice.ToString());
                LvFoodItem.SubItems.Add(food.categoryName.ToString());
                LvFoodItem.Tag = food.idFood;

                lv_food.Items.Add(LvFoodItem);
            }
        }
        public void FoodGroupLoad()
        {
            List<FoodCategory> tableCategoryList = FoodCategoryDAO.getInstance.getListFoodCategory();
            lv_FoodCategory.Items.Clear();
            foreach (var item in tableCategoryList)
            {
                ListViewItem LvCategoryItem = new ListViewItem(item.categoryName);
                LvCategoryItem.Tag = item.idFoodCategory;
                lv_FoodCategory.Items.Add(LvCategoryItem);
            }
        }
        public void StaffLoad()
        {
            List<Staff> staffList = StaffDAO.Instance.StaffGetList();
            lv_staff.Items.Clear();
            foreach (var item in staffList)
            {
                ListViewItem lvItem = new ListViewItem(item.id.ToString());
                lvItem.SubItems.Add(item.name);
                lvItem.SubItems.Add(item.phone.ToString());
                lvItem.SubItems.Add(item.cmnd.ToString());
                lvItem.SubItems.Add(item.address.ToString());
                lvItem.SubItems.Add(item.postion.ToString());
                lvItem.SubItems.Add(item.dayCheckIn.ToString());
                lvItem.SubItems.Add(item.salarybasic.ToString());
                lvItem.Tag = item.id;
                lv_staff.Items.Add(lvItem);
            }
        }

        // Thêm bàn mới
        private void btn_addTable_Click(object sender, EventArgs e)
        {
            fTableNew newTable = new fTableNew();
            newTable.TableLoad += TableLoad;
            newTable.Show();
        }
        // Truyền dữ liệu về Combobox
        public void loadTableaAreaListCombobox()
        {
            List<TableArea> lisTableArea = TableDAO.Instance.tableAreaList();
            cb_tableAreaList.DataSource = lisTableArea;
            cb_tableAreaList.DisplayMember = "nameTableArea";
        }
        private void btn_updateTable_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lv_table.Tag);
            if (lv_table.SelectedItems.Count > 0)
            {
                _idTable = (int)lv_table.FocusedItem.Tag;
                _nameTable = lv_table.SelectedItems[0].Text;
                fTableUpdate updateTable = new fTableUpdate(_idTable, _nameTable);
                updateTable.TableLoad += TableLoad;
                updateTable.Show();
                
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn cần cập nhật!","Thông báo");
            }
        }

        private void btn_deleteTable_Click(object sender, EventArgs e)
        {
            if (lv_table.SelectedItems.Count > 0)
            {
                _idTable = (int)lv_table.FocusedItem.Tag;
                DialogResult rs = MessageBox.Show("Bạn muốn xóa bàn này?", "Delete Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    TableDAO.Instance.DeleteTable(_idTable);
                    TableLoad();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn cần xóa!","Thông báo");
            }
        }


        private void btn_addFood_Click(object sender, EventArgs e)
        {
            fFoodNew foodNew = new fFoodNew();
            foodNew.FoodLoad += FoodLoad;
            foodNew.Show();
        }

        private void btn_foodUpdate_Click(object sender, EventArgs e)
        {
            if (lv_food.SelectedItems.Count > 0)
            {
                _idFood = (int)lv_food.FocusedItem.Tag;
                _foodName = lv_food.SelectedItems[0].Text;
                _foodPrice = Convert.ToDouble(lv_food.SelectedItems[0].SubItems[1].Text);
                _foodCategoryName = lv_food.SelectedItems[0].SubItems[2].Text;

                fFoodUpdate foodUpdate = new fFoodUpdate(_idFood, _foodName, _foodPrice, _foodCategoryName);
                foodUpdate.FoodLoad += FoodLoad;
                foodUpdate.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm cần update!");
            }
        }

        private void btn_foodDelete_Click(object sender, EventArgs e)
        {
            if (lv_food.SelectedItems.Count > 0)
            {
                _idFood = (int)lv_food.FocusedItem.Tag;
                DialogResult rs = MessageBox.Show("Bạn muốn xóa sản phẩm này?", "Delete Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    FoodDAO.getInstance.FoodDeleteId(_idFood);
                    FoodLoad();

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm cần xóa!");
            }
        }

        private void btn_areaAdd_Click(object sender, EventArgs e)
        {
            fTableAreaNew tableAreaNew = new fTableAreaNew();
            tableAreaNew.TableAreaLoad += TableAreaLoad;
            tableAreaNew.Show();
        }
        //
        private void btn_areaUpdate_Click(object sender, EventArgs e)
        {
            if (lv_areaTable.SelectedItems.Count > 0)
            {
                _idTableArea = (int)lv_areaTable.FocusedItem.Tag;
                _nameTableArea = lv_areaTable.SelectedItems[0].Text;
                fTableAreaUpdate tableUpdate = new fTableAreaUpdate(_idTableArea, _nameTableArea);
                tableUpdate.TableAreaLoad += TableAreaLoad;
                tableUpdate.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn khu vực bàn cần update!");
            }

        }
        //
        private void btn_areaDelete_Click(object sender, EventArgs e)
        {
            if (lv_areaTable.SelectedItems.Count > 0)
            {
                _idTableArea = (int)lv_areaTable.FocusedItem.Tag;
                DialogResult rs = MessageBox.Show("Bạn muốn xóa khu vực bàn này?", "Delete Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    TableDAO.Instance.TableAreaDeleteById(_idTableArea);
                    TableAreaLoad();

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn khu vực bàn cần xóa!");
            }
        }
        //
        private void btn_foodGroupAdd_Click(object sender, EventArgs e)
        {
            fFoodGroupNew foodGroupNew = new fFoodGroupNew();
            foodGroupNew.FoodGroupLoad += FoodGroupLoad;
            foodGroupNew.Show();
        }
        //
        private void btn_foodGroupDelete_Click(object sender, EventArgs e)
        {
            if (lv_FoodCategory.SelectedItems.Count > 0)
            {
                int _idFoodGroup = (int)lv_FoodCategory.FocusedItem.Tag;
                DialogResult rs = MessageBox.Show("Bạn muốn xóa nhóm sản phẩm này?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    FoodCategoryDAO.getInstance.FoodGroupDelete(_idFoodGroup);
                    FoodGroupLoad();

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhóm sản phẩm cần xóa!");
            }
        }
        //
        private void btn_foodGroupUpdate_Click(object sender, EventArgs e)
        {
            if (lv_FoodCategory.SelectedItems.Count > 0)
            {
                int _idFoodGroup = (int)lv_FoodCategory.FocusedItem.Tag;
                string _nameFoodGroup = lv_FoodCategory.SelectedItems[0].Text;
                fFoodGroupUpdate foodGroupUpdate = new fFoodGroupUpdate(_idFoodGroup, _nameFoodGroup);
                foodGroupUpdate.FoodGroupLoad += FoodGroupLoad;
                foodGroupUpdate.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhóm sản phẩm cần update");
            }

        }

        private void btn_staffAdd_Click(object sender, EventArgs e)
        {
            fStaffAdd staffAdd = new fStaffAdd();
            staffAdd.staffLoad += StaffLoad;
            staffAdd.Show();
        }

        private void btn_satffUpdate_Click(object sender, EventArgs e)
        {
            if (lv_staff.SelectedItems.Count > 0)
            {
                int idStaff = (int)lv_staff.SelectedItems[0].Tag;
                string name = lv_staff.SelectedItems[0].SubItems[1].Text;
                string phone = lv_staff.SelectedItems[0].SubItems[2].Text;
                string cmnd = lv_staff.SelectedItems[0].SubItems[3].Text;
                string address = lv_staff.SelectedItems[0].SubItems[4].Text;
                string position = lv_staff.SelectedItems[0].SubItems[5].Text;
                string salaryBasic = lv_staff.SelectedItems[0].SubItems[7].Text;


                fStaffUpdate staffAdd = new fStaffUpdate(idStaff, name, phone, cmnd, address, position, salaryBasic);
                staffAdd.staffLoad += StaffLoad;
                staffAdd.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần update");
            }

        }
        private void btn_staffDelete_Click(object sender, EventArgs e)
        {
            if (lv_staff.SelectedItems.Count > 0)
            {
                int idStaff = (int)lv_staff.FocusedItem.Tag;
                DialogResult rs = MessageBox.Show("Bạn muốn xóa nhân viên này?", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    StaffDAO.Instance.StaffDelete(idStaff);
                    StaffLoad();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần xóa!");
            }
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;   // Title Bar - Window

            //Remove border and keep window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }



        private Size formSize;
        private void maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            fLogin admin = new fLogin();
            this.Hide();
            admin.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void lv_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_table.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_table.SelectedItems[0];
                txt_nameTable.Text = selectedItem.SubItems[0].Text; // Cột 0
                cb_tableAreaList.Text = selectedItem.SubItems[2].Text; // Cột 1
            }
        }
    }
}

