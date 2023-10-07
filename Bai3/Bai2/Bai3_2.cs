using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Bai3_2 : Form
    {
        public Bai3_2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtX.Text);
            if (a > 0 && a <= 12)
            {
                if (a <= 5 && a >= 3) MessageBox.Show("Mua xuan");
                else if (a == 12 || a <= 2) MessageBox.Show("Mua dong");
                else if (a <= 8 && a > 5) MessageBox.Show("Mua he");
                else if (a <= 11 && a > 8) MessageBox.Show("Mua thu");
                
            }
            else MessageBox.Show("Phai nhap vao thang 1 den thang 12 trong nam!");
        }
    }
}
