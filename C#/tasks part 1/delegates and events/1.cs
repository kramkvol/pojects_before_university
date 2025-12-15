using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public delegate double funk2(double x);

    class Program
    {
        // "персональный" вариант. Вы дали мне тригонометрическую функцию,
        // котороя принимает одно значение, а не 2
        // и изменили шаг на 0.2, тк при шаге 7 получается выход из цикла.
        public static void tabl2(funk2 F, double x, double b)
        {
            Console.WriteLine("|X______|____F(x)________");
            while (x <= b)
            {
                Console.WriteLine("| " + x + "\t|" + Math.Round(F(x), 3));
                x += 0.2;
            }
            Console.WriteLine("_________________________");
        }
        static void Main()
        {
            Console.WriteLine(" Таблица функции Acos(x) : ");
            tabl2(new funk2(Math.Acos), 0, 1);
            Console.WriteLine();
            Console.WriteLine(" Таблица функции Cosh(x): ");
            tabl2(new funk2(Math.Cosh), 0, 1);
            Console.ReadKey();
        }

    }
}
