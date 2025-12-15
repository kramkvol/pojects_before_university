using System;
using System.Text.RegularExpressions;

namespace _1__общее_вар_8
{
    class Program
    {
        static void Main()
        {
            //  \b\w + (e) ? s(\s |$)
            // \b - граница слова
            // \w - слово
            // + (e) ? - ленивый квантификатор
            string[] data1 = { "yteb" } ;
            string pattern = @"\b\w + (e) ? s(\s |$)";
            foreach (string x in data1)
            {
                if (Regex.IsMatch(x, pattern))
                {
                    Console.WriteLine("Подходит: " + x);
                }
                else
                    Console.WriteLine("Бред какой-то: " + x);
            }
            Console.ReadKey();            
        }
    }
}
