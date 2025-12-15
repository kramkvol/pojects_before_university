using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Mnojestva a1 = new Mnojestva(1, 4, 6, -3, 5, 11);
                a1.Print("Множество 1");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Mnojestva a2 = new Mnojestva(6, 7, 4, 6, -3, 5);
                a2.Print("Множество 2");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}

