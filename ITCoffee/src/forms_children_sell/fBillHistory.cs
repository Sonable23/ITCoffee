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

namespace ITCoffee.src.forms_children
{
    public partial class fBillHistory : Form
    {
        public fBillHistory()
        {
            InitializeComponent();
            Create_ListBillHistory();
        }
        public void Create_ListBillHistory()
        { 
            List<BillHistory> listBillHistory = BillDAO.getInstance.BillHistory();
            foreach (var item in listBillHistory)
            {
                ListViewItem LvItem = new ListViewItem(item.idBill.ToString());
                LvItem.SubItems.Add(item.tableName.ToString());
                LvItem.SubItems.Add(item.dataCheckIn.ToString());
                LvItem.SubItems.Add(item.dataCheckOut.ToString());
                LvItem.SubItems.Add(item.messageBill.ToString());

                lv_listBillHistory.Items.Add(LvItem);
            }
        }
    }
}
