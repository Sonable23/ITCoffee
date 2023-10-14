using ITCoffee.src.DAO;
using ITCoffee.src.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCoffee.src.forms_children
{
    public partial class fBillReport : Form
    {
        private double _totalPriceAll;
        public fBillReport()
        {
            InitializeComponent();
            Create_ListBillReport();
        }

        public void Create_ListBillReport()
        {
            List<BillReport> listBillReport = BillDAO.getInstance.BillReport();
            foreach (var item in listBillReport)
            {
                ListViewItem LvItem = new ListViewItem(item.idBill.ToString());
                LvItem.SubItems.Add(item.tableName.ToString());
                LvItem.SubItems.Add(item.dataCheckIn.ToString());
                LvItem.SubItems.Add(item.dataCheckOut.ToString());
                LvItem.SubItems.Add(item.messageBill.ToString());
                LvItem.SubItems.Add(item.totalPrice.ToString());

                lv_listBillReport.Items.Add(LvItem);

                _totalPriceAll += item.totalPrice;
                CultureInfo culture = new CultureInfo("vi-VN");
                btn_totalBillAll.Text = _totalPriceAll.ToString("c", culture);
            }
        }

        private void btn_totalBillAll_Click(object sender, EventArgs e)
        {

        }
    }
}
