using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***GIAI VA BIEN LUAN PHUONG TRINH BAC 1***");
            Console.Write("Nhap vao a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao b: ");
            float b = float.Parse(Console.ReadLine());
            if (a != 0)
            {
                Console.WriteLine("Phuong trinh co nghiem duy nhat x=-b/a= " + (-b / a));
            }
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                { 
                    Console.WriteLine("Phuong trinh vo nghiem");
                } 
            }
            Console.ReadKey();
        }
    }
}
