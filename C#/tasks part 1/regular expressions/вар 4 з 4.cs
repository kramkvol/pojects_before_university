using System;
using System.Text.RegularExpressions;
public class Example
{
    public static void Main()
    {
        string[] values = { "123.45.300.78", "256.45.32.78", "200.65.80.78", "123.45.32.78", "970.67" };
        string pattern = (@"((1\d\d|2([0-4]\d|5[0-5])|\D\d\d?)\.?){4}$"); ;
        foreach (string value in values)
        {
            if (Regex.IsMatch(value, pattern))
            {
                Console.WriteLine("IP: " + value);
            }
            else Console.WriteLine("Not IP: " + value);
        }        
        Console.ReadKey();
    }
}