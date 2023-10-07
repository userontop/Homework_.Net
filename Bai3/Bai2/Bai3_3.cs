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
    public partial class Bai3_3 : Form
    {
        public Bai3_3()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int ngay = int.Parse(txtNgay.Text);
            int thang = int.Parse(txtThang.Text);
            int nam = int .Parse(txtNam.Text);
            if ((thang == 4 || thang == 6 || thang == 9 || thang == 11 || thang != 2) && ngay >= 30)
                MessageBox.Show("Ngay khong hop le!");
            else if (thang == 2 && ngay > 29 && (nam % 4 == 0 && nam % 100 != 0))
                MessageBox.Show("Ngay Khong hop le!");
            else if (thang == 2 && ngay > 28)
                MessageBox.Show("Ngay khong hop le!");
            else if (ngay <= 31)
                MessageBox.Show("Ngay hop le!");
        }
    }
}
