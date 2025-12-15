using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Y : X, Interface1
    {
        public double y;
        public Y()
        {
            y = 0;
        }
        public Y(double y_, double x1_, double x_2) : base(x1_, x_2)
        {
            y = y_;
        }
        public new void input()
        {
            Console.WriteLine("Ввдите у:");
            string buf3 = Console.ReadLine();
            y = Convert.ToDouble(buf3);
        }
        public new void output()
        {
            Console.WriteLine("y = " + y);
        }
        public void Run()
        {
            Console.WriteLine("Заначение х1*у + х2 = " + (x1 * y + x2));
        }
    }
}
