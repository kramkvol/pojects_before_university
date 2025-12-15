using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Tringle : Interf
    {
        public double a;
        public double b;
        public double c;
        public Tringle()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public Tringle(double a_, double b_, double c_)
        {
            a = a_;
            b = b_;
            c = c_;
        }
        public double square()
        {
            double p = (a + b + c)/2;
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return square;
        }
        public void inf()
        {
            Console.WriteLine(" Стороны треугольника: a = {0}; b = {1}; c = {2};\n Площадь треугольника = {3}\n ", a, b, c, square());
        }
    }
}
