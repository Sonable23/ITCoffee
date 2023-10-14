using ITCoffee.src.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ITCoffee.src.forms_children_admin
{
    public partial class fTableAreaNew : Form
    {
        public delegate void Delegate();
        public Delegate TableAreaLoad;
        public fTableAreaNew()
        {
            InitializeComponent();
        }

        private void btn_saveTableArea_Click(object sender, EventArgs e)
        {
           
           if(txt_TableArea.Text != "")
            {
                TableDAO.Instance.TableAreaInsert(txt_TableArea.Text);
                if(TableAreaLoad != null)
                {
                    TableAreaLoad();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên khu vực bàn!");
            }
        }
    }
}
