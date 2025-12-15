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
            Interf abcd = new Rectangle(3, 4); // 2 сп
            abcd.square();
            abcd.inf();
            Tringle abc = new Tringle(3, 4, 5);
            abc.square();
            abc.inf();
            Console.ReadKey();
        }
    }
}
