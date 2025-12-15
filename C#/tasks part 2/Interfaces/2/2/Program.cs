using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Intrf abcd = new SQ(3); // 2 сп
            abcd.square();
            abcd.inf();
            Tringle abc = new Tringle(3, 4, 5);
            abc.square();
            abc.inf();
            Console.ReadKey();
        }
    }
}
