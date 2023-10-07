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
    public partial class Bai4_7 : Form
    {
        public Bai4_7()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtN.Text);
            float tong = 1;
            while (n != 1)
            {
                tong *= ((n-1)*n);
                n--;
            }
            txtResuit.Text = tong.ToString();
        }
    }
}
