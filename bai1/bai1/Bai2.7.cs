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
    public partial class Bai2_7 : Form
    {
        public Bai2_7()
        {
            InitializeComponent();
        }


        private void click_cong(object sender, EventArgs e)
        {
            int a, b, tong;
            a = int.Parse(this.txtso1.Text);
            b = int.Parse(this.txtso2.Text);
            tong = a + b;
            resuit.Text = tong.ToString();
        }

        private void Click_tru(object sender, EventArgs e)
        {
            int a, b, tru;
            a = int.Parse(this.txtso1.Text);
            b = int.Parse(this.txtso2.Text);
            tru = a - b;
            resuit.Text = tru.ToString();
        }

        private void Click_Nhan(object sender, EventArgs e)
        {
            int a, b, tich;
            a = int.Parse(this.txtso1.Text);
            b = int.Parse(this.txtso2.Text);
            tich = a * b;
            resuit.Text = tich.ToString();
        }

        private void Click_Chia(object sender, EventArgs e)
        {
            int a, b;
            float thuong;
            a = int.Parse(this.txtso1.Text);
            b = int.Parse(this.txtso2.Text);
            thuong = (float)a / b;
            resuit.Text = thuong.ToString();
        }


    }
}
