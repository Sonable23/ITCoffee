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
    public partial class fTableAreaUpdate : Form
    {
        public delegate void Delegate();
        public Delegate TableAreaLoad;

        private int _idTableArea;
        public fTableAreaUpdate(int idTableArea,string tableAreaName)
        {
            InitializeComponent();
            txt_TableArea.Text = tableAreaName;
            _idTableArea = idTableArea;
        }

        private void btn_saveTableArea_Click(object sender, EventArgs e)
        {
            if (txt_TableArea.Text != "")
            {
                TableDAO.Instance.TableAreaUpdate(_idTableArea , txt_TableArea.Text);
                if(TableAreaLoad != null)
                {
                    TableAreaLoad();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên khu vực bàn cần update!");
            }
        }
    }
}
