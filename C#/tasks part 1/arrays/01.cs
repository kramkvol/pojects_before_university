using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(10, 15);
            int[] a = new int[number];  
            int i = 0;
            int sum = 0;
            int last = -1;

            for(i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(0, 10);
                if (a[i] == 0)
                {
                    last = i;
                }
                Console.Write(" " + a[i]);
            }
            Console.WriteLine();
            if ( last == -1)
            {
                Console.WriteLine("нет 0");
            }
            else 
                for ( i = last; i < a.Length; i++)
                {
                    sum += a[i];
                }
            Console.WriteLine("Сумма элементов массива после 0: " + sum);
            Console.ReadKey();
        }   
       
    }
}