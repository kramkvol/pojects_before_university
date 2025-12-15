using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static public double square(double c_, double h_)
        {
            return c_ * h_;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите среднюю линию: ");
            string buf1 = Console.ReadLine();
            Console.WriteLine("Введите высоту: ");
            string buf2 = Console.ReadLine();
            double c = Convert.ToInt32(buf1);
            double h = Convert.ToInt32(buf2);
            try
            {
                if (c == 0 | h == 0)
                {
                    Console.WriteLine("Значение не может быть равно нулю");
                }
                if (c < 0 | h < 0)
                {
                    Console.WriteLine("Значение не может быть отрицательным");
                }
            }
            catch
            {
                Console.WriteLine("Площадь трапеции: " + square(c, h));
            }
            Console.ReadKey();
        }
    }
}
