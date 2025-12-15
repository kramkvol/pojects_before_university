using System;
using System.Text.RegularExpressions;

namespace _1__вар_8
{
    class Program
    {
        public static void Main()
        {
            // Имя георграфического объекта - довольно широкое понятие...
            // Пусть будет проверка на области и районы.
            string[] values = { "Город Минск","Минская область", "Заводской район", "Птичь"};
            string pattern = @"\w\s(область|район)$";
            foreach (string value in values)
            {
                if (Regex.IsMatch(value, pattern))
                {
                    Console.WriteLine("По формату: " + value);
                }
                else Console.WriteLine("Не по формату: " + value);
            }
            Console.ReadKey();
        }
    }
}
