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

namespace ITCoffee.src.forms_children_sell
{
    public partial class fChangePassword : Form
    {
        public delegate void myDelegate();
        public myDelegate closeApp;
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPasswordOld.Text != "" && txtPasswordNew.Text != "" && txtPasswordNewMore.Text != "")
            {
                string username = txtUsername.Text;
                string passwordOld = txtPasswordOld.Text;
                string passwordNew = txtPasswordNew.Text;
                string passwordNewMore = txtPasswordNewMore.Text;
                if(passwordNew == passwordNewMore)
                {
                    if(AccountDAO.Instance.ChangPassword(username, passwordOld, passwordNew) > 0)
                    {
                        DialogResult rs = MessageBox.Show("Bạn đã đổi mật khẩu thành công! Chúng tôi sẽ restart lại app của bạn! Vui lòng đăng nhập lại!");
                        if(rs == DialogResult.OK)
                        {
                          
                            if(closeApp != null)
                            {
                                closeApp();
                            }
                            Close();
                        }

                    }else
                    {
                        MessageBox.Show("Sai Username hoặc Password! Vui lòng kiểm tra lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không khớp!");
                }
            }
        }
    }
}
