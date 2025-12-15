using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class X : Interface1
    {
        public double x1;
        public double x2;
        public X ()
        {
            x1 = 0;
            x1 = 0;
        }
        public X(double x1_, double x2_)
        {
            x1 = x1_;
            x2 = x2_;
        }
        public void input()
        {
            Console.WriteLine("Ввдите x1:");
            string buf1 = Console.ReadLine();
            x1 = Convert.ToDouble(buf1);
            Console.WriteLine("Ввдите x2:");
            string buf2 = Console.ReadLine();
            x2 = Convert.ToDouble(buf2);
        }
        public void output()
        {
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }

    }
}
