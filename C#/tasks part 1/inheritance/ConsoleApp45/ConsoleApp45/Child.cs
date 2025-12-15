
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Child : Perent
    {
        public DateTime MinOp;
        public Child(DateTime MinOp)
        {
            this.MinOp = MinOp;
        }
        public Child()
        {
            this.MinOp = new DateTime(0);
        }
        
        public double FMinOp (DateTime MinOp)
        {
            int IntMinOP = MinOp.Minute;
            double MinOP_ = GM() / IntMinOP;
            return MinOP_;
        }
        public void MinOP()
        {
            Console.WriteLine("За указанное время можно выполнить *" + FMinOp() + "* операций.");
        }
    }
}
