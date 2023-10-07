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
    public partial class frmBai6 : Form
    {
        public frmBai6()
        {
            InitializeComponent();
        }

        private void so1(object sender, EventArgs e)
        {

        }

        private void so2(object sender, EventArgs e)
        {

        }

        private void Tong(object sender, EventArgs e)
        {
            int a, b, tong;
            a = int.Parse(this.txtso1.Text);
            b = int.Parse(this.txtso2.Text);
            tong = a + b;
            MessageBox.Show("tong = " + a + " + " + b + " = " + tong);
        }

        private void Tru(object sender, EventArgs e)
        {
            int a, b, tru;
            a = int.Parse(this.txtso1.Text);
            b = int.Parse(this.txtso2.Text);
            tru = a - b;
            MessageBox.Show("hieu = " + a + " - " + b + " = " + tru);
        }

        private void Nhan(object sender, EventArgs e)
        {
            int a, b, tich;
            a = int.Parse(this.txtso1.Text);
            b = int.Parse(this.txtso2.Text);
            tich = a * b;
            MessageBox.Show("tich = " + a + " * " + b + " = " + tich);
        }

        private void chia(object sender, EventArgs e)
        {

            int a, b;
            float thuong;
            a = int.Parse(this.txtso1.Text);
            b = int.Parse(this.txtso2.Text);
            thuong = (float)a / b;
            MessageBox.Show("thuong = " + a + " / " + b + " = " + (float)thuong);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
