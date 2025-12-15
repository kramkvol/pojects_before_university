using System;
namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int count = 1;
            for(int i = a; i < b+1; i++)
            {
                count = count * i;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
