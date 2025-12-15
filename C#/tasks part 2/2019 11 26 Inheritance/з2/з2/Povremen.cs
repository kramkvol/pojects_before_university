using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace з2
{
    class Povremen : ZP
    {
        public int Wnumber;
        public string WName;
        public Povremen()
        {
            Wnumber = 0;
            WName = "Нет иформации о имени";
            PochasovayaStavka = 0;
        }
        public Povremen(int WNum, string WN, double Pst)
        {
            Wnumber = WNum;
            WName = WN;
            PochasovayaStavka = Pst;
        }
        public override double ALLZP()
        {
            ZPPovremennaya = 20.8 * 8 * PochasovayaStavka;
            return ZPPovremennaya;
        }
        public override void inf ()
        {
            Console.WriteLine(" Номер: {0}\n Имя: {1}\n Тип: повременная оплата труда\n Зарплата: {2}", Wnumber, WName, ALLZP() + "\n");
        }
        public override void inf_num()
        {
            Console.WriteLine(" Номер: " + Wnumber);
        }
    }
}
