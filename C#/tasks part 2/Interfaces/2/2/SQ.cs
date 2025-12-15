using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class SQ : Intrf
    {
        public double a;
        public SQ()
        {
            a = 0;
        }
        public SQ(double a_)
        {
            a = a_;
        }
        public double square()
        {
            return a * a;
        }
        void Intrf.inf() // 2 сп
        {
            Console.WriteLine(" Сторона квадрата: a = {0};\n Площадь квадрата = {1}\n ", a, square());
        }
    }
}
