using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace з2
{
    class FIx : ZP
    {
        public int Wnumber;
        public string WName;
        public FIx()
        {
            Wnumber = 0;
            WName = "Нет иформации о имени";
            ZPFix = 0;
        }
        public FIx(int WNum, string WN, double Fpl) 
        {
            WName = WN;
            Wnumber = WNum;
            FixPlata = Fpl;
        }
        public override double ALLZP()
        {
            ZPFix = FixPlata;
            return ZPFix;
        }
        public override void inf()
        {
            Console.WriteLine(" Номер: {0}\n Имя: {1}\n Тип: фиксированная оплата труда\n Зарплата: {2}", Wnumber, WName, ALLZP() + "\n");
        }
        public override void inf_num()
        {
            Console.WriteLine(" Номер: " + Wnumber);
        }
    }
}
