using System;
namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " Какая-то строка.";
            char[] a = str.ToCharArray();
            int CodeFirst = 0;
            int CodeLast = 0;
            for (int i = 0; i < a.Length; i++)
            {
                CodeLast = Convert.ToInt32(str[i]);
            }
            CodeFirst = Convert.ToInt32(str[0]);
            Console.WriteLine(CodeFirst);
            Console.WriteLine(CodeLast);
            Console.ReadKey();
        }
    }
}
