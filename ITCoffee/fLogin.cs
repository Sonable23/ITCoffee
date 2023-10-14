using ITCoffee.src.DAO;
using ITCoffee.src.dataProvider;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ITCoffee
{
    public partial class fLogin : Form
    {
        private Size formSize;
        private string _Mode;

        public fLogin()
        {
            InitializeComponent();

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (tb_Username.Text == "" || tb_Password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để đăng nhập vào app!");
                return;
            }
            else
            {
                if (AccountDAO.Instance.Login(tb_Username.Text, tb_Password.Text))
                {
                    if (this._Mode == btnNhanVien.Text)
                    {
                        fSell sell = new fSell();
                        this.Hide();
                        sell.Show();
                    }
                    else if (this._Mode == btnAdmin.Text)
                    {
                        fAdmin admin = new fAdmin();
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn chế độ đăng nhập!");
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    return;
                }
            }
        }
        
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this._Mode = btnAdmin.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this._Mode = btnNhanVien.Text;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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
            Application.Exit();
        }
        //Overridden methods
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

    }
}
