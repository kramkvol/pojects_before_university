using System;
namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            int n = 10;
            int i = k;
            int count = 0;
            while (i < n)
            {
                i++;
                count += k;
                if (count*count > n)
                {
                    Console.WriteLine(count);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
