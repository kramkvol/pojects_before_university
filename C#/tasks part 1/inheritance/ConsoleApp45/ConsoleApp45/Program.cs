using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45 
{
    class Program
    {
        static void Main(string[] args)
        {
            Perent t1 = new Perent();
            t1.Hour = DateTime.Now;
            t1.Min = DateTime.Now;
            t1.GeneralMin();
            Child t2 = new Child();
            t2.MinOp = DateTime.Today;
            t2.MinOP();
            Console.ReadKey();
        }
    }
}
