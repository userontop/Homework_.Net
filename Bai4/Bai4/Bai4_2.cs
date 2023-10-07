using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Bai4_2 : Form
    {
        public Bai4_2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtN.Text);
            float tong = 0;
            while (n != 0)
            {
                tong += (n*n);
                n--;
            }
            txtResuit.Text = tong.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtResuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
