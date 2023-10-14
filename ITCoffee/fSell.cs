using ITCoffee.src.DTO;
using ITCoffee.src.forms_children;
using ITCoffee.src.forms_children_sell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCoffee
{
    public partial class fSell : Form
    {
        public fSell()
        {
            InitializeComponent();
            // default size width menu
            if (toggleMenu == false)
            {
                menu.Width = icon_Menu.Width;
                fp_container.Width = this.Width - menu.Width;
            }
            // auto open children phong ban
            openChildrenPhongBan();
        }
        //var toggle menu
        private bool toggleMenu = false;
        private Size formSize;
        private int borderSize = 1;


        //method dong mo menu
        private void handleToggleMenu()
        {
            if (toggleMenu == false)
            {
                this.toggleMenu = true;
                menu.Width = 250;
                fp_container.Width = this.Width - menu.Width;
            }
            else
            {
                this.toggleMenu = false;
                menu.Width = 50;
                fp_container.Width = this.Width - menu.Width;
            }
        }

        //open children phong ban
        public void openChildrenPhongBan()
        {
            fPhongban phongban = new fPhongban();
            phongban.TopLevel = false;
            phongban.FormBorderStyle = FormBorderStyle.None;
            phongban.Dock = DockStyle.Fill;
            //truyền panel container sang form 
            phongban.SetFlowLayoutPanel(fp_container);
            fp_container.Controls.Clear();
            fp_container.Controls.Add(phongban);
            phongban.Show();
        }
        public void openChildrenFormBillHistory()
        {
            fBillHistory history = new fBillHistory();
            history.TopLevel = false;
            history.FormBorderStyle = FormBorderStyle.None;
            history.Dock = DockStyle.Fill;
            fp_container.Controls.Clear();
            fp_container.Controls.Add(history);
            history.Show();
        }
        public void openChildrenFormBillReport()
        {
            fBillReport billReport = new fBillReport();
            billReport.TopLevel = false;
            billReport.FormBorderStyle = FormBorderStyle.None;
            billReport.AutoScroll = true;
            billReport.Dock = DockStyle.Fill;
            fp_container.Controls.Clear();
            fp_container.Controls.Add(billReport);
            billReport.Show();
        }
        private void icon_Menu_Click(object sender, EventArgs e)
        {
            handleToggleMenu();

        }

        //thay doi giao dien (mode)

        //phong ban
        private void btnPhongBan_Click(object sender, EventArgs e)
        {


            handleToggleMenu();
            openChildrenPhongBan();
        }

        private void btn_support_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ email nghiabatuoidev@gmail.com để được hỗ trợ! Xin cảm ơn bạn đã sử dụng dịch vụ!", "Support", MessageBoxButtons.OK);
        }
        private void btnSyncData_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thực hiện đồng bộ hóa dự liệu!", "SyncData", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                openChildrenPhongBan();
            }
        }



        private void btn_BillHistory_Click(object sender, EventArgs e)
        {
            openChildrenFormBillHistory();
        }

        private void btn_BillReport_Click(object sender, EventArgs e)
        {
            openChildrenFormBillReport();
        }

        public void Close_Click(object sender, EventArgs e)
        {
            fLogin admin = new fLogin();
            this.Hide();
            admin.Show();

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
            handleToggleMenu();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fSell_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
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
        public void closeApp()
        {
            this.Close();
        }
        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            fQuydinh quydinh = new fQuydinh();
            quydinh.Show();
            quydinh.TopLevel = false;
            quydinh.FormBorderStyle = FormBorderStyle.None;
            quydinh.AutoScroll = true;
            quydinh.Dock = DockStyle.Fill;
            fp_container.Controls.Clear();
            fp_container.Controls.Add(quydinh);
            quydinh.Show();
        }

        private void btnUserManual_Click(object sender, EventArgs e)
        {
            fUserManual uManual = new fUserManual();
            uManual.Show();
            uManual.TopLevel = false;
            uManual.FormBorderStyle = FormBorderStyle.None;
            uManual.AutoScroll = true;
            uManual.Dock = DockStyle.Fill;
            fp_container.Controls.Clear();
            fp_container.Controls.Add(uManual);
            uManual.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            fSetting setting = new fSetting();
            setting.Show();
            setting.TopLevel = false;
            setting.FormBorderStyle = FormBorderStyle.None;
            setting.AutoScroll = true;
            setting.Dock = DockStyle.Fill;
            fp_container.Controls.Clear();
            fp_container.Controls.Add(setting);
            setting.closeApp += closeApp;
            setting.Show();
        }
    }
}
