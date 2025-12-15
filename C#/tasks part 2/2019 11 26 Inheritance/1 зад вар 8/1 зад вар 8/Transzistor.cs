using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_зад_вар_8
{
    class Transzistor 
    {
        public string type { set; get; }
        public int number { set; get; }
        public Transzistor()
        {
            type = "Нет информации о типе транзистора";
            number = 0;
        }
        public Transzistor(string TP, int num)
        {
            type = TP;
            number = num;
        }
        public void Passport()
        {
            Console.WriteLine("Тип транзистора: " + type + "\nНомер: " + number);
        }
    }
}
