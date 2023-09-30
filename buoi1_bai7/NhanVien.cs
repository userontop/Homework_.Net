using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai7
{
    class NhanVien
    {
        private int id;
        private String name;
        private int yearOfBirth;
        private double salaryLevel;
        static private double basicSalary = 200000;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }
        public double SalaryLevel { get => salaryLevel; set => salaryLevel = value; }
        private static double BasicSalary { get => basicSalary; set => basicSalary = value; }

        public void Input() {
            Console.Write(" \t -Nhap Dinh danh:");
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \t -Nhap ho ten:");
            this.name = Console.ReadLine();
            Console.Write(" \t -Nhap Nam sinh:");
            this.yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \t -Nhap bac luong:");
            this.salaryLevel = double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.Write(" \t -Nhap Dinh danh:" + this.id);
            Console.Write(" \t -Nhap ho ten:" + this.name);
            Console.Write(" \t -Nhap Nam sinh:" + this.yearOfBirth);
            Console.Write(" \t -Nhap luong:" + (this.salaryLevel * BasicSalary));
        }
    }
}
