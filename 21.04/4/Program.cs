using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите числовое значение оценки");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("понедельник");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("вторник");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("среда");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("четверг");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("пятница");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("суббота");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("воскресенье");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("ошибка ввода данных");
                        break;
                    }


            }
            Console.ReadKey();
        }
    }
}
