using System;
using System.IO;
namespace ConsoleApp36
{
    class Program
    {
        static void Main()
        {
            int min = 0;
            int max = 0;
            int InMin = 0;
            int InMax = 0;
            int temp = 0;
            using (BinaryWriter text = new BinaryWriter(new FileStream("nums.txt", FileMode.Create, FileAccess.Write)))
            {
                int[] num = new int[4];
                Console.WriteLine(" ¬ведите 4 целых числа: ");
                for (int i = 0; i < num.Length; i++)
                {
                    string num_buf = Console.ReadLine();
                    num[i] = Convert.ToInt32(num_buf);
                }

                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] > 0)
                    {
                        min = num[i];
                        InMin = i;
                    }
                    if (num[i] < max)
                    {
                        max = num[i];
                        InMax = i;
                    }
                }
                Console.Write("*************");
                Console.WriteLine();
                temp = num[InMax];
                num[InMax] = num[InMin];
                num[InMin] = temp;
                for (int i = 0; i < num.Length; i++)
                {
                    text.Write(num[i]);
                }
            }
            using (BinaryReader text = new BinaryReader(new FileStream("nums.txt", FileMode.Open, FileAccess.Read)))
            {
                while (text.PeekChar() > -1)
                {
                    Console.WriteLine(text.ReadInt32());
                }
            }
            Console.ReadKey();
        }
    }
}
