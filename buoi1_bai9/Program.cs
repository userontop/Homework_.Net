using System;

namespace buoi1_bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phuong trinh 1:");
            PhuongTrinhB2 pT2 = new PhuongTrinhB2();
            pT2.A = 4;
            pT2.B = 2;  
            pT2.C = 5;
            pT2.DisPlay();

            Console.WriteLine("Phuong trinh 2:");
            PhuongTrinhB2 pT_2 = new PhuongTrinhB2(3, 5, -1);
            pT_2.DisPlay();
        }
    }
}
