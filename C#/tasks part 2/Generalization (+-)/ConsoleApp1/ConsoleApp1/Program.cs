using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        public class Stack<T> //шаблонный класс, собственный класс-прототип
        {
            int count; //количество элементов в стеке

            T[] items; //сами элементы стека
            int top; //вершина стека
            public int Count //свойство  “количество”
            {
                get { return count; }
                set { if ((top > 0) && (top <= count)) count = value; else Console.WriteLine("Error!!!"); }
            }
            public void InitStack() //первоначальное создание стека
            {
                Console.Write("Введите количество элементов стека: ");
                count = Convert.ToInt32(Console.ReadLine());
                items = new T[count]; //выделяем память для массива элементов стека 
                top = count; //первоначально вершина стека – в конце
            }
            public bool EndOfStack()//конец стека?
            {
                if (top == count) return true;
                else return false;
            }
            public void Push(T item)//помещение элемента в стек
            {
                if (top == 0) { Console.WriteLine("Error"); return; }
                else
                {
                    items[top - 1] = item;
                    top = top - 1;
                }
            }
            public T Pop() //извлечение элемента из стека
            {
                if (top == count) { Console.WriteLine("Error"); } else top = top + 1; return items[top - 1];
            }

        }
        static void Main(string[] args)
        {
            //При использовании класса-прототипа вместо параметра Т подставляется //конкретный тип данных
            //стек целых чисел
            Stack<int> ints = new Stack<int>();
            ints.InitStack();
            for (int i = 0; i < ints.Count; i++)
                ints.Push(i);
            while (!ints.EndOfStack())
            {
                int x = ints.Pop();
                Console.WriteLine(x + " ");
            }
            //стек дробных чисел
            Stack<double> double_s = new Stack<double>();
            double_s.InitStack();
            for (double i = 0; i < double_s.Count; i++)
                double_s.Push(i);
            while (!double_s.EndOfStack())
            {
                double y = double_s.Pop();
                Console.WriteLine("{0:f}", y);
            }
            Console.ReadKey();
        }
    }
}
