﻿using System;

namespace buoi1_bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime timenow = System.DateTime.Now;
            Console.WriteLine("\t goi ham tao khong tham so");
            ThoiGian t1 = new ThoiGian();
            t1.Hien();
            ThoiGian t2 = new ThoiGian(12, 10, 2014, 4, 56, 39);
            t2.Hien();
            ThoiGian t3 = new ThoiGian(20, 05, 2014);
            t3.Hien();
            ThoiGian t4 = new ThoiGian(t3);
            t4.Hien();
            ThoiGian t5 = new ThoiGian(timenow);
            t5.Hien();
            Console.ReadKey();
        }
    }
    }
