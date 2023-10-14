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
    public partial class fInputDiaLog : Form
    {
        public string Input { get; private set; }
        public string nameFood;
        public fInputDiaLog(int count, string nameFood)
        {
            InitializeComponent();
            this.nameFood = nameFood;
            lb_InputDiaLog.Text = $"Số lượng {nameFood}";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Lưu giá trị nhập từ TextBox vào biến Input
            Input = txt_Count.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txt_Count_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CountCong_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(txt_Count.Text) + 1;
            txt_Count.Text = count.ToString();

        }

        private void btn_CountTru_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(txt_Count.Text) - 1;
            txt_Count.Text = count.ToString();
        }
    }
}
