using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] a = new int[10];
            int min = 10;
            int max = -1;
            int InMin = -1;
            int InMax = -1;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-9, 9);
                Console.Write(" " + a[i]);

                    if (a[i] > 0 & a[i] < min)
                    {
                        min = a[i];
                        InMin = i;
                    }
                    if (a[i] < max)
                    {
                        max = a[i];
                        InMax = i;
                    }

            }
            Console.WriteLine();
            Console.WriteLine("Минимальный положительный: " + min);
            Console.WriteLine("Максимальный отрицательный: " + max);
            int k, t = 0;
            if (InMin < InMax)
            {

                 for (k = 0; k < InMin; k++)
                {
                    Console.Write(" " + a[k]);
                }
                Console.Write(" " + min);
                for (t = InMax; t < a.Length; t++)
                {
                    Console.Write(" " + a[t]);
                }
            }
            else
            {
                Console.WriteLine("Мин. пол. элемент расположен позже макс. отр.");
            }

            Console.ReadKey();
        }

    }
}