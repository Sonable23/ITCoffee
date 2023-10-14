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

namespace ITCoffee.src.forms_children_sell
{
    public partial class fxuathoadon : Form
    {
        

        public fxuathoadon()
        {
            InitializeComponent();
        }
        public string TenBan { get; set; }
        public string TongTien { get; set; }
        public int MaHoaDon { get; set; }
        public string NgayTao { get; set; }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            txtTenBan.Text = TenBan;
            txtTongTien.Text = TongTien;
            txtMaHoaDon.Text = MaHoaDon.ToString();
            txtNgayTaoHD.Text = NgayTao;

            string noiDungHoaDon = $"\t\t\tTHÔNG TIN HOÁ ĐƠN" +
                $"\n\n\tMã Hoá Đơn: {txtMaHoaDon.Text} " +
                $"\n\n\tTên bàn: {txtTenBan.Text}" +
                $"\n\n\tTổng tiền: {txtTongTien.Text}" +
                $"\n\n\tNgày/Giờ: {txtNgayTaoHD.Text}";

            // Lưu nội dung hóa đơn vào tệp Notepad
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HoaDon|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                System.IO.File.WriteAllText(filePath, noiDungHoaDon);
                MessageBox.Show("Xuất hóa đơn thành công!");
                Close();
            }
        }
//quá là hợp lí, đang test github
        private void fxuathoadon_Load(object sender, EventArgs e)
        {
            txtTenBan.Text = TenBan;
            txtTongTien.Text = TongTien;
            txtMaHoaDon.Text = MaHoaDon.ToString();
            txtNgayTaoHD.Text = NgayTao;
        }
    }
}
