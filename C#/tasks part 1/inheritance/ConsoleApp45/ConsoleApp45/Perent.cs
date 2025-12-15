using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Perent
    {
        public DateTime Hour;
        public DateTime Min;

        public Perent (DateTime hour, DateTime min)
        {
            this.Hour = hour;
            this.Min = min;
        }
        public Perent ()
        {
            this.Hour = new DateTime(0);
            this.Min = new DateTime(0);
        }
        public double GM ()
        {
            int GM = Hour.Hour * 60 + Min.Minute;
            return GM;
        }
        public void GeneralMin ()
        {
            Console.WriteLine("Общее количество минут: " + GM());
        }

    }
}
