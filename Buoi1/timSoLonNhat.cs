using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class timSoLonNhat
    {
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            //khai bao phuong thuc nhap to int32 -- 32bit
            return so;
        }
        public int TimMax(int so1, int so2, int so3)
        {
            int max;
            max = so1 > so2 ? so1 : so2;
            //if so1 > so2 then so1 else so2
            max = max > so3 ? max : so3;
            //if so1 > so2 then so1 else so2
            return max;
        }
    }
}
