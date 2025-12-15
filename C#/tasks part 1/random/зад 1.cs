using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n;
            n = rand.Next(2, 10);
            int[,] a = new int[n, n];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    a[r, c] = rand.Next(10);
                    Console.Write(" " + a[r, c]);
                }
                Console.WriteLine();
            }

            if (n % 2 != 0)
            {
                Console.WriteLine("Число строк нечёт");
                Console.ReadKey();
            }
            else
            Console.WriteLine("Число строк чёт");
            for (int r = 1; r < n; r += 2)
            {
                for (int c = 0; c < n; c++)
                {
                    int temp = a[r, c];
                    a[r, c] = a[r - 1, c];
                    a[r - 1, c] = temp;   
                }
                Console.WriteLine();
            }
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(" " + a[r, c]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
