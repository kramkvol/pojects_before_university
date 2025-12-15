using System;
namespace ConsoleApplication1
{
    public class Program
    {
        public static double a, b, h;
        public static double result(double a, double b, double h)
        {
            double result = 0;
            for (double x = a; x < b; x += h)
            {
                 result = Math.Pow(x, 2) * Math.Pow(15 + 10 *
                 Math.Sin(x + Math.PI), 1 / 2);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" ¬ведите A: ");
            string bufA = Console.ReadLine();
            a = Convert.ToDouble(bufA);

            Console.WriteLine(" ¬ведите B: ");
            string bufB = Console.ReadLine();
            b = Convert.ToDouble(bufB);

            Console.WriteLine(" ¬ведите шаг h: ");
            string bufh = Console.ReadLine();
            h = Convert.ToDouble(bufh);
            Console.WriteLine(result(a, b, h));
            Console.ReadKey();
        }
    }
}