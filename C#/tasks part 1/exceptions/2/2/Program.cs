using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int column = 2;
            int row = 3;
            try
            {
                int[,] a = new int[row, column];
                Random rand = new Random();
                Console.WriteLine("Массив: ");
                for (int r = 0; r < row; r++)
                {
                    for (int c = 0; c < column; c++)
                    {
                        a[r, c] = rand.Next(-1, 9);
                        if (a[r, c] >= 0) Console.Write("  " + a[r, c]);
                        if (a[r, c] < 0) Console.Write(" " + a[r, c]);
                    }
                    Console.WriteLine();
                }
                if (a[2, 0] < 0)
                {
                    Console.WriteLine(" столбец3 сумма = " + (a[2, 0] + a[1, 0] + a[0, 0]));
                    Console.WriteLine("Координаты: [2, 0] ");
                }
                if (a[1, 1] < 0)
                {
                    Console.WriteLine(" столбец2 сумма = " + (a[2, 1] + a[1, 1] + a[0, 1]));
                    Console.WriteLine("Координаты: [1, 1] ");
                }
                if (a[0, 2] < 0)
                {
                    Console.WriteLine(" столбец1 сумма = " + (a[2, 2] + a[1, 2] + a[0, 2]));
                    Console.WriteLine("Координаты: [0, 2] ");
                }
            }
            catch(IndexOutOfRangeException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            
            Console.ReadKey();
        }
    }
}
