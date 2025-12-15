using System;
using System.IO;
using System.Collections.Generic;
namespace ConsoleApp36
{
    class Program
    {
        static int min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static int max(int a, int b)
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static void Main()
        {
            Stack<int> numbers = new Stack<int>();
            using (TextReader text = File.OpenText("текст.txt"))
            {
                char[] line = File.ReadAllText("текст.txt").ToCharArray();
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '0'|| line[i] == '1' || line[i] == '2' || line[i] == '3' 
                        || line[i] == '4' || line[i] == '5' || line[i] == '6' || 
                        line[i] == '7' || line[i] == '8' || line[i] == '9')
                    {
                        numbers.Push(line[i]);
                        Console.Write(line[i] + " ");
                    }
                }
            }
            Console.WriteLine();
            int min_ = min((char)numbers.Pop(), (char)numbers.Pop());
            int max_ = min((char)numbers.Pop(), (char)numbers.Pop());
            int res = max(min_, max_);
            Console.WriteLine("Результат M(m(3, 5),M(1, 2)) = " + (char)res);
            Console.ReadKey();
        }
    }
}