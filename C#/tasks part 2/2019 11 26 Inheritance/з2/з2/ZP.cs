using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace з2
{
    abstract class ZP 
    {
        public double ZPPovremennaya;
        public double ZPFix;
        public double PochasovayaStavka;
        public double FixPlata;
        public virtual double ALLZP ()
        {
            return 0;
        }
        public virtual void inf() {}
        public virtual void inf_num() { }
    }
}
