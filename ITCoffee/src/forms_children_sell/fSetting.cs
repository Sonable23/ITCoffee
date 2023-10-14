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
    public partial class fSetting : Form
    {
        public delegate void myDelegate();
        public event myDelegate closeApp;
        public fSetting()
        {
            InitializeComponent();
        }
        public void close()
        {
            if(closeApp != null)
            {
                closeApp();
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            fChangePassword chPassword = new fChangePassword();
            chPassword.closeApp += close;
            chPassword.Show();
        }
    }
}
