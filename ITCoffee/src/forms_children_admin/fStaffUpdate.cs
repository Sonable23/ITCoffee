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
    public partial class fStaffUpdate : Form
    {
        public delegate void myDelegate();
        public myDelegate staffLoad;
        private int _idStaff;
        public fStaffUpdate(int idStaff, string name, string phone, string cmnd, string address, string position, string salaryBasic)
        {
            InitializeComponent();
            _idStaff = idStaff;
            txt_staffName.Text = name;
            txt_staffPhone.Text = phone;
            txt_staffCmnd.Text = cmnd;
            txt_staffAddress.Text = address;
            cb_staffPosition.Text = position;
            txt_staffSalaryBasic.Text = salaryBasic;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (txt_staffName.Text != "" && txt_staffPhone.Text != "" && txt_staffCmnd.Text != "" && txt_staffAddress.Text != "" && txt_staffSalaryBasic.Text != "")
            {

                string name = txt_staffName.Text;
                int phone = Convert.ToInt32(txt_staffPhone.Text);
                int cmnd = Convert.ToInt32(txt_staffCmnd.Text);
                string address = txt_staffAddress.Text;
                string position = cb_staffPosition.SelectedItem.ToString();
                double salaryBasic = Convert.ToDouble(txt_staffSalaryBasic.Text);
                StaffDAO.Instance.StaffUpdate(_idStaff, name, phone, cmnd, address, position, salaryBasic);

                if (staffLoad != null)
                {
                    staffLoad();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
            }
        }
    }
}
