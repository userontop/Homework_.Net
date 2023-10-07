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
    public partial class Bai : Form
    {
        public Bai()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);
            float delta = b * b - 4 * a * c;
            float x1 = (-b + (float)Math.Sqrt(delta)) / (2*a);
            float x2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
            if (delta > 0)
            {
                txtResuit.Text = Convert.ToString("PT co 2 nghiem: x1: " + x1 + ", x2: " + x2);
            }
            else if (delta < 0)
                txtResuit.Text = "Pt vo Nghiem";
            else 
            {
                x1 = x2 = -b / (2*a);
                txtResuit.Text = Convert.ToString("PT co nghiem kep: x1: " + x1 + ", x2: " + x2);
            }
        }
    }
}
