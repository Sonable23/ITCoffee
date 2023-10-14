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
using System.Xml.Linq;

namespace ITCoffee.src.forms_children
{
    public partial class fPhongban : Form
    {
        //biến nhận panel
        private Panel _flowLayoutPanelFromSell;
        public fPhongban()
        {
            InitializeComponent();
            loadTable();
        }

        public void loadTable()
        {
            //table all
            List<Table> tablesList = TableDAO.Instance.tableList();
            foreach (Table table in tablesList)
            {
                Button button = new Button() { Width = 150, Height = 100 };
                button.Text = $" {table.Name}\n({table.Status})";
                button.Tag = table.Id;
                int idBill = BillDAO.getInstance.GetUncheckBillByTableId(table.Id);
                button.BackColor = table.Status == "Sử dụng" ? Color.BlueViolet : Color.Empty;
                //hiển thị item ra flowlayoutpanel
                fp_getListTable_All.Controls.Add(button);
                //khi click button thì open form order
                button.Click += Btn_Click_OpenOrder;
            }
            //table sử dụng
            foreach (Table table in tablesList)
            {
                if (table.Status == "Sử dụng")
                {
                    Button button = new Button() { Width = 150, Height = 100 };
                    button.Text = $" {table.Name}\n({table.Status})";
                    button.Tag = table.Id;
                    button.BackColor = table.Status == "Sử dụng" ? Color.BlueViolet : Color.Empty;
                    //hiển thị item ra flowlayoutpanel
                    fp_getListTable_Use.Controls.Add(button);
                    //khi click button thì open form order
                    button.Click += Btn_Click_OpenOrder;


                }

            }
            //table trống
            foreach (Table table in tablesList)
            {
                if (table.Status == "Trống")
                {
                    Button button = new Button() { Width = 150, Height = 100 };
                    button.Text = $" {table.Name}\n({table.Status})";
                    button.Tag = table.Id;
                    //hiển thị item ra flowlayoutpanel
                    fp_getListTable_NotUse.Controls.Add(button);
                    //khi click button thì open form order
                    button.Click += Btn_Click_OpenOrder;
                }

            }
            foreach (Table table in tablesList)
            {
                if (table.Name == "Mang về")
                {
                    Button button = new Button() { Width = 150, Height = 100 };
                    button.Text = $" {table.Name}\n({table.Status})";
                    button.Tag = table.Id;
                    //hiển thị item ra flowlayoutpanel
                    fp_getListTable_TakeAway.Controls.Add(button);
                    //khi click button thì open form order
                    button.Click += Btn_Click_OpenOrder;
                }

            }
            foreach (Table table in tablesList)
            {
                if (table.Name == "Giao đi")
                {
                    Button button = new Button() { Width = 150, Height = 100 };
                    button.Text = $" {table.Name}\n({table.Status})";
                    button.Tag = table.Id;
                    //hiển thị item ra flowlayoutpanel
                    fp_getListTable_Ship.Controls.Add(button);
                    //khi click button thì open form order
                    button.Click += Btn_Click_OpenOrder;
                }

            }
        }
        //btn CLick open order
        private void Btn_Click_OpenOrder(object sender, EventArgs e)
        {
            // Lấy Button được click
            Button button = (Button)sender;
            string nameTable = (string)button.Text;
            int tableId = (int)button.Tag;
            // Hiển thị tên của Button 
            // Truyền tableId qua form order
          
            fOrder order = new fOrder(tableId, nameTable);
            order.TopLevel = false;
            order.FormBorderStyle = FormBorderStyle.None;
            order.Dock = DockStyle.Fill;
            order.SetFlowLayoutPanel(_flowLayoutPanelFromSell);
            _flowLayoutPanelFromSell.Controls.Clear();
            _flowLayoutPanelFromSell.Controls.Add(order);
            order.Show();
        }
        //hàm nhận panel từ form sell
        public void SetFlowLayoutPanel(Panel flowLayoutPanel)
        {
            _flowLayoutPanelFromSell = flowLayoutPanel;
        }

        private void fp_getListTable_All_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
