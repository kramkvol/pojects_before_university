using System;
using System.Text.RegularExpressions;

namespace ConsoleApplication181
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "23:16:37", "01:12:67", "23:59:31", "20:16:01" };
            string pattern = "(?<hour>[0-2][0-3]):(?<min>[0-5][0-9]):(?<sec>[0-5][0-9])";
            foreach (string value in values)
            {
                if (Regex.IsMatch(value, pattern))
                {
                    DateTime dt = Convert.ToDateTime(value);
                    if (dt.Second > 30)
                    {
                        dt = dt.AddMinutes(1);
                        dt = dt.AddSeconds(-dt.Second);
                    }
                    Console.WriteLine("Было: " + value + "\t После округления: " + dt.TimeOfDay);
                }
                else Console.WriteLine("Не верный формат: " + value);
            }
            Console.ReadKey();
        }
    }
}
