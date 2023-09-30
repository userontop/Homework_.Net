using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai9
{
    class PhuongTrinhB2
    {
        private float a, b, c;

        public PhuongTrinhB2()
        {
            a = b = c = 0;
        }
        public PhuongTrinhB2(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }
        public float C { get => c; set => c = value; }

        public void TinhNghiem()
        {
            float delta = b * b - 4 * a * c;
            if (delta < 0)
                Console.WriteLine("Phuong trinh vo nghiem.");
            else if (delta == 0) Console.WriteLine("Phuong trinh co nghiem kep: " + (-b / (2 * a)).ToString());
            else 
            {
                float x1 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                float x2 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Phuong trinh co 2 nghiem: \nx1 = " + x1.ToString() + " \nx2 = " + x2.ToString());
            }
        }

        public void DisPlay()
        {
            Console.WriteLine("a: " + a.ToString());
            Console.WriteLine("b: " + b.ToString());
            Console.WriteLine("b: " + c.ToString());
            this.TinhNghiem();
        }
    }
}
