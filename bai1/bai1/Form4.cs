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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void BtnHienthi(object sender, EventArgs e)
        {

             MessageBox.Show("thong bao " + this.Text_input.Text + " Bi Khung");
        }

        private void text_input(object sender, EventArgs e)
        {

        }
    }
}
