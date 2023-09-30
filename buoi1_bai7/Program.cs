using System;

namespace buoi1_bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write(" Nhap so luong Nhan Vien: ");
            n = int.Parse(Console.ReadLine());
            NhanVien[] _employees = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" Nhap thong tin Nhan vien thu: " + (i + 1).ToString());
                _employees[i] = new NhanVien();
                _employees[i].Input();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" \nIn thong tin Nhan vien thu: " + (i + 1).ToString());
                _employees[i].Display();
            }

        }
    }
}
