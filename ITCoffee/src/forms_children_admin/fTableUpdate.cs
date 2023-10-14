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

namespace ITCoffee.src.forms_children_admin
{
    public partial class fTableUpdate : Form
    {
        public delegate void Delegate();
        public Delegate TableLoad;
        //
        private string _newTableName;
        private int _newTableAreaId;
        private int _idTable;
        private string _nameTable;
        public fTableUpdate(int idTable, string nameTable)
        {
            InitializeComponent();
            loadTableaAreaListCombobox();
            _idTable = idTable;
            _nameTable = nameTable;
            txt_nameTable.Text = _nameTable;
        }
        public void loadTableaAreaListCombobox()
        {
            List<TableArea> lisTableArea = TableDAO.Instance.tableAreaList();

            cb_tableAreaList.DataSource = lisTableArea;
            cb_tableAreaList.DisplayMember = "nameTableArea";
            
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            _newTableName = txt_nameTable.Text;
            _newTableAreaId = (cb_tableAreaList.SelectedItem as TableArea).idTableArea;
            TableDAO.Instance.TableUpdate(_idTable, _newTableName, _newTableAreaId);
            if(TableLoad != null) 
            {
                TableLoad();
                Close();
            }
            MessageBox.Show("Cập nhật thành công", "Thông báo");
        }
    }
}
