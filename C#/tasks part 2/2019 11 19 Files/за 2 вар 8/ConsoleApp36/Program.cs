using System;
using System.IO;
namespace ConsoleApp36
{
    class Program
    {
        static void Main()
        {
            using (TextReader text = File.OpenText("стих.txt"))
            {
                while (text.Peek() > -1)
                {
                    Console.WriteLine(text.ReadLine()[0]);
                }
            }   
            Console.ReadKey();
        }
    }
}
