using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            const int row = 4;
            const int column = 6;
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();
            char[,] a = new char[row, column] {
                { 'н', 'ь','т', 'е', 'л', 'ю'},
                { ' ', ' ',' ', ' ', ' ', ' '},
                { ' ', ' ',' ', ' ', ' ', ' '},
                { ' ', ' ',' ', ' ', ' ', ' '},};

            char[,] b = new char[row, column] {
                { 'т', 'ю','л', 'е', 'н', 'ь'},
                { ' ', ' ',' ', ' ', ' ', ' '},
                { ' ', ' ',' ', ' ', ' ', ' '},
                { ' ', ' ',' ', ' ', ' ', ' '},
            };

            for (int c = 0; c < column; c++) 
            {
                for (int r = 1; r < row; r++)
                {
                    if (c * row + r < str.Length)
                        a[r, c] = str[c * row + r];
                    else
                        a[r, c] = ' ';
                }
            }

            for (int r = 0; r < row; r++) 
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write(" " + a[r, c]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Шифр: ");

            for (int r = 1; r < row; r++) 
            {
                for (int c = 0; c < column; c++)
                {
                    if (a[0, c] == 'т')
                    {
                        b[1, 0] = a[1, c];
                        b[2, 0] = a[2, c];
                        b[3, 0] = a[3, c];
                    }

                    if (a[0, c] == 'ю')
                    {
                        b[1, 1] = a[1, c];
                        b[2, 1] = a[2, c];
                        b[3, 1] = a[3, c];
                    }

                    if (a[0, c] == 'л')
                    {
                        b[1, 2] = a[1, c];
                        b[2, 2] = a[2, c];
                        b[3, 2] = a[3, c];
                    }

                    if (a[0, c] == 'е')
                    {
                        b[1, 3] = a[1, c];
                        b[2, 3] = a[2, c];
                        b[3, 3] = a[3, c];
                    }

                    if (a[0, c] == 'н')
                    {
                        b[1, 4] = a[1, c];
                        b[2, 4] = a[2, c];
                        b[3, 4] = a[3, c];
                    }

                    if (a[0, c] == 'ь')
                    {
                        b[1, 5] = a[1, c];
                        b[2, 5] = a[2, c];
                        b[3, 5] = a[3, c];
                    }
                }

            }
            Console.WriteLine();
            for (int r = 0; r < row; r++) 
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write(" " + b[r, c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int c = 0; c < column; c++)  
            {
                for (int r = 0; r < row; r++)
                {
                    Console.Write(b[r, c]);
                }
            }
            Console.ReadKey();
        }
    }
}