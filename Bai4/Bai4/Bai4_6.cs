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
    public partial class Bai4_6 : Form
    {
        public Bai4_6()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtN.Text);
            float tong = 0;
            while (n != 0)
            {
                tong += (1/(2*n-1));
                n--;
            }
            txtResuit.Text = tong.ToString();
        }
    }
}
