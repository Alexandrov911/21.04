using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число c");
            double c = Convert.ToInt32(Console.ReadLine());
            if (((a * a) == (b * b + c * c))|| (b * b == (a * a + c * c)) || (c * c == (a * a + b * b)))
            {
                Console.WriteLine("прямоугольный");
            }
            else
            {
                Console.WriteLine("не прямоугольный");
            }
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("площадь равна" + s);
            
            Console.ReadKey();
        }
    }
}
