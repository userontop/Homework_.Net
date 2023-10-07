using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai1
{
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
        }

        private void so1(object sender, EventArgs e)
        {

        }

        private void so2(object sender, EventArgs e)
        {

        }

        private void Tinh_Tong(object sender, EventArgs e)
        {
            int a, b, tong;
            a = int.Parse(this.txtso1.Text);
            b = int.Parse(this.txtso2.Text);
            tong = a + b;
            MessageBox.Show("tong = " + a + " + " + b + " = " + tong);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
