using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string buf;
            Console.WriteLine("¬ведите трЄхзначное число: ");
            buf = Console.ReadLine();
            int k = Convert.ToInt32(buf);
            int s = 0;
            while (k != 0)
            {
                s += k % 10;
                k /= 10;
            }
            Console.WriteLine("S = " + s);
            Console.ReadKey();

        }
    }
}
