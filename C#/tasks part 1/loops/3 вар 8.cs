using System;
namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = -1;
            double b = 3;
            Console.WriteLine("Введите Х: ");
            string buf = Console.ReadLine();
            double step = Convert.ToDouble(buf);
            if (step > 1.5)
            {
                double y = 0;
                while (a < b)
                {
                    a += step;
                    y = step;
                    step++;
                    Console.WriteLine(y);
                }
            }
            if (step >= 0 && step <= 1.5)
            {
                double y = 0;
                for (double i = a; a < b; step++)
                {
                    a += step;
                    y = 2 * Math.Pow(step, 2) * Math.Sqrt(Math.Abs(Math.Cos(2 * step)));
                    Console.WriteLine(y);
                }
            }
            if (step < 0)
            {
                double y = 0;
                for (double i = a; a < b; step++ )
                {
                    a += step;
                    y = Math.Exp(-Math.Cos(3 * step));
                    Console.WriteLine(y);
                }
            }
            Console.ReadKey();
        }
    }
}
