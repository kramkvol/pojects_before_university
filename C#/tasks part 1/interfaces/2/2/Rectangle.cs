using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Rectangle : Intrf
    {
        public double a;
        public double b;
        public Rectangle()
        {
            a = 0;
            b = 0;
        }
        public Rectangle(double a_, double b_)
        {
            a = a_;
            b = b_;
        }
        public double square()
        {
           return a*b;
        }
        void Interf.inf() // 2 сп
        {
            Console.WriteLine(" Стороны прямоугольника: a = {0}; b = {1};\n Площадь прямоугольника = {2}\n ", a, b, square());
        }
    }
}
