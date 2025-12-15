using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Y z1 = new Y();
            z1.input();
            z1.output();
            X z2 = new X();
            z2.input();
            z2.output();
            Y res = new Y(z1.y, z2.x1, z2.x2);
            res.Run();
            Console.ReadKey();
        }
    }
}
