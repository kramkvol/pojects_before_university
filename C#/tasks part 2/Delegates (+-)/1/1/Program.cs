using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public delegate double funk(double x, double y);
    public delegate double funk2(double x);

    class Program
    {
        public static void tabl1(funk F, double x, double y, double b)
        {
            Console.WriteLine("|X______|Y______|_F(x,y)_");
            while (x <= b)
            {
                Console.WriteLine("| " + x + "\t|" + y + "\t|" + Math.Round(F(x,y), 3));
                x += 1; //шаг
            }
            Console.WriteLine("_________________________");
        }
        public static void tabl2(funk2 F, double x, double b)
        {
            Console.WriteLine("|X______|____F(x)________");
            while (x <= b)
            {
                Console.WriteLine("| " + x + "\t|" +  Math.Round(F(x),3));
                x += 1; // шаг
            }
            Console.WriteLine("_________________________");
        }
        static void Main()
        {
            double b = 5;
            double x = 0;
            double y = 0.3;
            Console.WriteLine(" Предел значения x: " + b);
            Console.WriteLine(" x = " + x);
            Console.WriteLine(" у = " + y);
            Console.WriteLine(" Таблица функции Atan2(x) : ");
            tabl1(new funk(Math.Atan2), x, y, b);
            Console.WriteLine();
            Console.WriteLine(" Таблица функции Cosh(x): ");
            tabl2(new funk2(Math.Cosh), x, b);
            Console.ReadKey();
        }
    }
}
