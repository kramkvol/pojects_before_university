using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace з2
{
    class Program
    {
        static void Main(string[] args)
        {
            ZP a1 = new Povremen(1, "Работник20", 80.5);
            ZP a2 = new Povremen(2, "Работник11", 70.3);
            ZP a3 = new Povremen(3, "Работник15", 75.2);
            ZP a4 = new Povremen(4, "Работник1", 81.2);
            ZP b1 = new FIx(5, "Работник 5", 1060.4);
            ZP b2 = new FIx(6, "Работник 6", 1063.4);
            ZP b3 = new FIx(7, "Работник 7", 1060.4);
            ZP b4 = new FIx(8, "Работник 8", 1072.4);
            List<ZP> obj = new List<ZP>() { a1, a2, a3, a4, b1, b2, b3, b4 };
            var sort1 = from u1 in obj
                        orderby u1.ALLZP()  
                        select u1;
            Console.WriteLine("Сортировка по ЗП: ");
            foreach (ZP u1 in sort1)
            {
                u1.inf();
            }
            Console.ReadKey();
        }
    }
}
