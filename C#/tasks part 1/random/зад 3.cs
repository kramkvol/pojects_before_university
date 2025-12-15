using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[][] a = new int[4][];
            a[0] = new int[4];
            a[1] = new int[3];
            a[2] = new int[6];
            a[3] = new int[10];
            
            for(int i = 0; i < 4; i++)
            {
                for(int y = 0; y < a[i].Length; y++)
                {
                    a[i][y] = rand.Next(-9, 9);
                    if (a[i][y] < 0) Console.Write( " " + a[i][y]);
                    else Console.Write("  " + a[i][y]);
                }
                Console.WriteLine();
            }

            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y < a[i].Length; y++)
                {
                    if (a[i][y] == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Ноликов: " + count);
            Console.ReadKey();
        }
    }    
}
