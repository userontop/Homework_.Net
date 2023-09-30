using System;
using System.Collections.Generic;//interfaces, classes, methods, events, delegates, structs.
using System.Linq;//list
using System.Text;//Console.OutputEncoding = Encoding.UTF8;
namespace Buoi1
{
    class Program
    {
            static void Main(string[] args)
            {
                System.Console.OutputEncoding = Encoding.UTF8;
            //su dung phuong thuc tieng viet UTF8
                timSoLonNhat sln = new timSoLonNhat();
            //khoi tao class timsolonnhat
                int a, b, c, max;
                System.Console.Write("Nhập a = ");
                a = sln.NhapMotSo();
                Console.Write("\nNhập b = ");
                b = sln.NhapMotSo();
                Console.Write("\nNhập c = ");
                c = sln.NhapMotSo();
                max = sln.TimMax(a, b, c);
                Console.WriteLine("Số lớn nhất trong 3 số {0}, {1} và {2} là {3}", a, b, c, max);
                Console.ReadLine();
            }
    }
}
