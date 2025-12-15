using System;

namespace ConsoleApp18
{
    class Program
    {
        static double result = 0;
        static double result_(double a, double b)
        {
            double x = 0;
            while (a < b)
            {
                result = Math.Pow(x, 2) * Math.Pow(15 + 10 * Math.Sin(x), 1 / 2);
                Console.WriteLine("x = {0}\t {1} результат = {2}", x, "|", result);
                x = x + 0.5;
                a = a + 0.5;
            }
            return result;
        }
        static void Main(string[] args)
        {
            double a = -0.4 * Math.PI;
            double b = 0.4 * Math.PI;
            result_(a, b);
            Console.ReadKey();
        }
    }
}
