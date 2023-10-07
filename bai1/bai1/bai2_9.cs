using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Bai2_9 : Form
    {
        public Bai2_9()
        {
            InitializeComponent();
        }

        private void btn_ChuVi_Click(object sender, EventArgs e)
        {
            int a, b, chuvi;
            a = int.Parse(this.txtso1.Text);
            b = int.Parse(this.txtso2.Text);
            chuvi = (a + b)*2;
            resuit.Text = chuvi.ToString();
        }

        private void btn_DienTich_Click(object sender, EventArgs e)
        {
            int a, b, dientich;
            a = int.Parse(this.txtso1.Text);
            b = int.Parse(this.txtso2.Text);
            dientich = a * b;
            resuit.Text = dientich.ToString();
        }

        private void btn_DuongCheo_Click(object sender, EventArgs e)
        {
            float a, b, duongCheo;
            a = float.Parse(this.txtso1.Text);
            b = float.Parse(this.txtso2.Text);
            duongCheo = (float)Math.Sqrt(a * a + b * b);
            resuit.Text = duongCheo.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void resuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
