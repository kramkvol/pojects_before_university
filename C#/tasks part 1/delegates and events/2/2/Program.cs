using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2015, 11, 23);
            Worker a1 = new Worker("ифо1", 4, "должность1", dt1);
            a1.Notify += DisplayMessage;
            //a1.inf();
            DateTime dt2 = new DateTime(2007, 11, 23);
            Worker a2 = new Worker("ифо2", 3, "должность1", dt2);
            a2.Notify += DisplayMessage;
            //a2.inf();
            DateTime dt3 = new DateTime(2011, 11, 23);
            Worker a3 = new Worker("ифо3", 2, "должность4", dt3);
            a3.Notify += DisplayMessage;
            //a3.inf();
            DateTime dt4 = new DateTime(2018, 11, 23);
            Worker a4 = new Worker("ифо4", 7, "должность2", dt4);
            a4.Notify += DisplayMessage;
            //a4.inf();
            List<Worker> obj = new List<Worker>() { a1, a2, a3, a4 };
            var sort1 = from u1 in obj
                        orderby u1.staj()
                        select u1;
            Console.WriteLine("Сортировка по стажу: ");
            foreach (Worker u1 in sort1)
            {
                u1.inf();
            }
            Console.ReadKey();
        }
    }
}
