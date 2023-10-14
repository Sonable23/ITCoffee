using ITCoffee.src.DAO;
using ITCoffee.src.dataProvider;
using ITCoffee.src.DTO;
using ITCoffee.src.forms_children_sell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using Table = ITCoffee.src.DTO.Table;

namespace ITCoffee.src.forms_children
{
    public partial class fOrder : Form
    {
        //idTable được truyền từ form phongban
        private string nameTable;
        private int _tableId = 0;
        private double _total_Price_menu = 0;
        private double _total_Count_Menu = 0;
        private Panel _flowLayoutPanelFromSell;

        public fOrder(int tableId, string nameTable)
        {
            InitializeComponent();
            this._tableId = tableId;
            this.nameTable = nameTable;
            create_MenuItem();
            load_FoodCategory();

            //default value = 1 auto load when open app
            load_FoodCategoryById(-1);
            //load data btn
            //đơn vị tiền tệ
            CultureInfo culture = new CultureInfo("vi-VN");
            btn_Total_Count.Text = $"Số lượng: {this._total_Count_Menu.ToString()}";
            btn_Total_Mount.Text = this._total_Price_menu.ToString("c", culture);
            //load tên bàn
            btn_NameTable.Text = $"{nameTable}";

            load_TableComBobox();

        }
        public void SetFlowLayoutPanel(Panel flowLayoutPanel)
        {
            _flowLayoutPanelFromSell = flowLayoutPanel;
        }
        public void openChildrenPhongBan()
        {
            fPhongban phongban = new fPhongban();
            phongban.TopLevel = false;
            phongban.FormBorderStyle = FormBorderStyle.None;
            phongban.Dock = DockStyle.Fill;
            //truyền panel container sang form phongban
            phongban.SetFlowLayoutPanel(_flowLayoutPanelFromSell);
            _flowLayoutPanelFromSell.Controls.Clear();
            _flowLayoutPanelFromSell.Controls.Add(phongban);
            phongban.Show();
        }
        public void load_TableComBobox()
        {
            List<Table> tablesList = TableDAO.Instance.tableList();

            cb_ListTable.DataSource = tablesList;
            cb_ListTable.DisplayMember = "Name";

        }
        // load Menu từng bàn
        private void create_MenuItem()
        {
            List<MenuFood> menuLFoodList = MenuFoodDAO.Instance.MenuList(_tableId);
            //trước khi cộng thì set = 0
            this._total_Count_Menu = 0;
            this._total_Price_menu = 0;
            foreach (var item in menuLFoodList)
            {
                ListViewItem LvItem = new ListViewItem(item.foodName.ToString());
                LvItem.SubItems.Add(item.count.ToString());
                LvItem.SubItems.Add(item.price.ToString());
                LvItem.SubItems.Add(item.totalPrice.ToString());
                LvItem.Tag = item.idFood;
                lv_ListMenu.Items.Add(LvItem);
                //
                this._total_Price_menu += item.totalPrice;
                this._total_Count_Menu += item.count;
            }
            //load data btn
            //đơn vị tiền tệ
            CultureInfo culture = new CultureInfo("vi-VN");
            btn_Total_Count.Text = $"Số lượng: {this._total_Count_Menu.ToString()}";
            btn_Total_Mount.Text = this._total_Price_menu.ToString("c", culture);
            btn_NameTable.Text = $"Bàn {_tableId}";
        }
        //foodCategory
        private void load_FoodCategory()
        {
            Button btnDefautl = new Button() { Width = 180, Height = 30 };
            btnDefautl.Text = "Tất cả";
            btnDefautl.Tag = -1;
            btnDefautl.Click += btn_Category_Click;
            fp_ListFoodCategory.Controls.Add(btnDefautl);
            List<FoodCategory> listFoodCategory = FoodCategoryDAO.getInstance.getListFoodCategory();
            foreach (var item in listFoodCategory)
            {
                Button btn = new Button() { Width = 180, Height = 30 };
                btn.Text = item.categoryName.ToString();
                btn.Tag = item.idFoodCategory;
                fp_ListFoodCategory.Controls.Add(btn);
                btn.Click += btn_Category_Click;
            }
        }
        // foodList theo by id category
        private void load_FoodCategoryById(int? idCategory = null)
        {
            List<Food> listFood = FoodDAO.getInstance.getListFoodByIdCategory(idCategory);
            lv_FoodCategory.Items.Clear();
            foreach (var item in listFood)
            {
                ListViewItem LvItem = new ListViewItem(item.foodName.ToString());
                LvItem.SubItems.Add(item.foodPrice.ToString());
                //gán idFood qua tag
                LvItem.Tag = item.idFood;
                lv_FoodCategory.Items.Add(LvItem);
            }
        }
        //tìm kiếm food theo tên
        private void load_FoodCategoryByName(string foodName)
        {
            List<Food> listFood = FoodDAO.getInstance.getListFoodByName(foodName);
            lv_FoodCategory.Items.Clear();
            foreach (var item in listFood)
            {
                ListViewItem LvItem = new ListViewItem(item.foodName.ToString());
                lv_FoodCategory.Items.Add(LvItem);
            }
        }
        //event click vào item FoodCategory
        public void btn_Category_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idCategory = (int)btn.Tag > 0 ? (int)btn.Tag : -1;
            load_FoodCategoryById(idCategory);
        }
        //btn back trở về trang trước 
        private void Close_Click(object sender, EventArgs e)
        {
            openChildrenPhongBan();
        }
        //btn search food
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string foodName = txt_SearchFood.Text;
            load_FoodCategoryByName(foodName);
        }
        //xác nhận
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            openChildrenPhongBan();

        }

        //click vào item list food thêm item đó vào listmenu
        private void lv_FoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_FoodCategory.SelectedItems.Count > 0)
            {
                int idBill = BillDAO.getInstance.GetUncheckBillByTableId(this._tableId);
                //lấy idFood qua tag of item listview
                int idFood = (int)lv_FoodCategory.FocusedItem.Tag;
                //nếu chưa có bill thì trả về -1
                if (idBill < 0)
                {
                    //insert bill
                    BillDAO.getInstance.InsertBill(this._tableId);
                    //lấy idBill vừa insert 
                    idBill = BillDAO.getInstance.GetUncheckBillByTableId(this._tableId);
                    //insert billinfor
                    BillInforDAO.getInstance.InsertBillInfor(idBill, idFood);
                    //load lại data
                    lv_ListMenu.Items.Clear();
                    create_MenuItem();

                }
                else
                {
                    //insert billinfor
                    BillInforDAO.getInstance.InsertBillInfor(idBill, idFood);
                    //load lại data
                    lv_ListMenu.Items.Clear();
                    create_MenuItem();
                }
            }
        }

        //click vào item trong list menu update count item đó
        private void lv_ListMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lv_ListMenu.SelectedItems.Count > 0)
            {
                int idBill = BillDAO.getInstance.GetUncheckBillByTableId(this._tableId);
                int idFood = (int)lv_ListMenu.FocusedItem.Tag;
                string nameFood = (string)lv_ListMenu.SelectedItems[0].SubItems[0].Text;
                using (var form = new fInputDiaLog(idFood, nameFood))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Lưu kết quả nhập vào biến result
                        int count = Convert.ToInt32(form.Input);
                        BillInforDAO.getInstance.UpdateCountBillInfor(idBill, idFood, count);
                        lv_ListMenu.Items.Clear();
                        create_MenuItem();
                    }
                }
            }
        }
        // thanh toán bill
        private void btn_CheckOutBill_Click(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            //Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.getInstance.GetUncheckBillByTableId(this._tableId);
            List<MenuFood> menuLFoodList = MenuFoodDAO.Instance.MenuList(_tableId);
            //trước khi cộng thì set = 0
            this._total_Count_Menu = 0;
            this._total_Price_menu = 0;
            foreach (var item in menuLFoodList)
            {
                ListViewItem LvItem = new ListViewItem(item.foodName.ToString());
                LvItem.SubItems.Add(item.count.ToString());
                LvItem.SubItems.Add(item.price.ToString());
                LvItem.SubItems.Add(item.totalPrice.ToString());
                LvItem.Tag = item.idFood;
                lv_ListMenu.Items.Add(LvItem);
                //
                this._total_Price_menu += item.totalPrice;
                this._total_Count_Menu += item.count;
            }
            if (idBill > 0)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn thanh toán hóa đơn này", "CheckOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    BillDAO.getInstance.BillCheckOut(idBill);
                    openChildrenPhongBan();
                    fxuathoadon hoaDon = new fxuathoadon();
                    hoaDon.TenBan = $"Bàn {_tableId}";
                    hoaDon.MaHoaDon = idBill;
                    hoaDon.NgayTao = DateTime.Now.ToString();
                    hoaDon.TongTien = this._total_Price_menu.ToString("c", culture);
                    hoaDon.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Hóa đơn not found!");
            }
        }


        private void cb_ListTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // chuyển bàn
        private void btn_MoveTable_Click(object sender, EventArgs e)
        {
            int idTable1 = this._tableId;
            int idTable2 = (cb_ListTable.SelectedItem as Table).Id;
            string nameTable2 = (cb_ListTable.SelectedItem as Table).Name;
            DialogResult rs = MessageBox.Show($"Bạn có muốn chuyển bàn {this.nameTable} sang {nameTable2} không?", "Move Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (idTable1 == idTable2)
                {
                    MessageBox.Show("Bàn bạn muốn chuyển bị trùng với bàn bạn đã chọn vui lòng chọn bàn khác!");
                }
                else
                {
                    TableDAO.Instance.handleTableSwitch(idTable1, idTable2);
                    openChildrenPhongBan();
                }
            }

        }
        // gộp bàn
        private void btn_combineTable_Click(object sender, EventArgs e)
        {
            int idTable1 = this._tableId;
            int idTable2 = (cb_ListTable.SelectedItem as Table).Id;
            string nameTable2 = (cb_ListTable.SelectedItem as Table).Name;
            DialogResult rs = MessageBox.Show($"Bạn có muốn gộp bàn {this.nameTable} sang {nameTable2} không?", "Move Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (idTable1 == idTable2)
                {
                    MessageBox.Show("Bàn bạn muốn gộp bị trùng với bàn bạn đã chọn vui lòng chọn bàn khác!");
                }
                else
                {
                    TableDAO.Instance.handleTableSwitch(idTable1, idTable2);
                    openChildrenPhongBan();
                }
            }
        }
        //xóa bill
        private void btn_DelBill_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.getInstance.GetUncheckBillByTableId(this._tableId);
            if (idBill > 0)
            {
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn hủy hóa đơn bàn{this.nameTable} không?", "Delete Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    BillDAO.getInstance.DeleteBill(idBill);
                    openChildrenPhongBan();
                }
            }
        }
    }

}
