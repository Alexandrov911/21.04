using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0) {
                if (y > 0)
                {
                    Console.WriteLine("1 четверть");
                }
                else
                {
                    Console.WriteLine("4 четверть");
                }
                
            }
            else
            {
                if (y>0)
                {
                    Console.WriteLine("2 четверть");
                }
                else
                {
                    Console.WriteLine("3 четверть");
                }

            }
            Console.ReadKey();
        }
    }
}
