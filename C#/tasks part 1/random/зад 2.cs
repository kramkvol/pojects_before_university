using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int row, column;
            row = rand.Next(2, 10);
            column = rand.Next(2, 10);
            int[,] a = new int[row, column];

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    a[r, c] = rand.Next(-9, 9);
                    if (a[r, c] < 0) Console.Write(" " + a[r, c]); 
                    else Console.Write("  " + a[r, c]);
                }
                Console.WriteLine();
            }
            Console.Write(" Новый массив: ");
            int[] b = new int[column];
            for (int c = 0; c < column; c++)
            {
                for(int r = 0; r < row; r++)
                {
                    if(a[r,c]>0)
                    {
                        b[c] = a[r, c];
                        break;
                    }
                }
            }

            Console.WriteLine();
            for(int i = 0; i < column; i++)
            {
                Console.Write(" " + b[i]);
            }

            Console.ReadKey();
        }
    }    
}
