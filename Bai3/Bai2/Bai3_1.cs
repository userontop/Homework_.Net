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
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtX.Text);
            float fx = 0;
            if (a >= 2) fx = -8 * a * a * a - 12 * a - 1;
            if (a < 2 && a > 1) fx = a * a - 6 * a - 19;
            if (a <= 1) fx = 7*a;
            txtF.Text = fx.ToString();
        }
    }
}
