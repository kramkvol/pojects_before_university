using System;
using System.Collections.Generic;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main()
        {
            Queue<char> digits = new Queue<char>();
            Queue<char> lettets = new Queue<char>();
            using (TextReader text = File.OpenText("инфа.txt"))
            {
                char[] line = File.ReadAllText("инфа.txt").ToCharArray();
                Console.WriteLine("Только цифры: ");
                for (int i = 0; i < line.Length; i++)
                {//if(line[i]>=48&line [i]<=57)
                  //  if(char.IsDigit(line[i]))
                    if (line[i] == '0' || line[i] == '1' || line[i] == '2' || line[i] == '3'
                        || line[i] == '4' || line[i] == '5' || line[i] == '6' ||
                        line[i] == '7' || line[i] == '8' || line[i] == '9')
                    {
                        digits.Enqueue(line[i]);
                        char digit = digits.Dequeue();
                        Console.Write(digit);
                    }
                    else
                        lettets.Enqueue(line[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Без цифр: ");
                for (int i = 0; i < lettets.Count; i++)
                {
                    char lett = lettets.Dequeue();
                    Console.Write(lett);
                }
            }
            Console.ReadKey();
        }
    }
}
