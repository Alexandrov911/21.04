using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите числовое значение оценки");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 2:
                    {
                        Console.WriteLine("неуд");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("уд");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("хорошо");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("отлично");
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
