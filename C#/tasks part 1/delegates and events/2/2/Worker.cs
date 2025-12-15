using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Worker
    {
        string IFO;
        int Otdel;
        string Doldjnost;
        DateTime BiganWork;
        public delegate void sozdanie (string message);
        public event sozdanie Notify;
        //public delegate double izmenenie();
        //public event izmenenie Notify2;
        public Worker()
        {
            IFO = "нет информации о имени";
            Otdel = 0;
            Doldjnost = "нет информации о должности";
            BiganWork = DateTime.Now;
        }
        public Worker(string ifo, int otd, string dl, DateTime dt)
        {
            IFO = ifo;
            Otdel = otd;
            Doldjnost = dl;
            BiganWork = dt;
        }
        public double staj()
        {
            Notify("Произошло действие");
            return DateTime.Now.Year - BiganWork.Year;
        }
        public void inf ()
        {
            Notify("Объект создан");
            Console.WriteLine(" ИФО: {0}\n Отдел: {1}\n Должность: {2}\n Стаж: {3} года (лет).\n", IFO, Otdel, Doldjnost, staj());
        }

    }
}
