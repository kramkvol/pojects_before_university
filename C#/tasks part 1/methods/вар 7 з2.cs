
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    public class Solution
    {
        public static double eps = 0.001;
        public static double function(double a) // не рекурсия
        {
            double X0, X = 0.5 * (1 + a);
            do
            {
                X0 = X;
                X = 0.5 * (X0 + a / X0);
            }
            while (Math.Abs(X - X0) > eps);
            return X;
        }
        public static double recursion(double a, double x) // рекурсия
        {
            double X0;         
             X0 = x;
             x = 0.5 * (X0 + a / X0);
            if (Math.Abs(x - X0) > eps)
                x = recursion(a, x);        
            return x;
        }
        static void Main(string[] args)
        {
            double a=10000, x = 0.5 * (1 + a);
            Console.WriteLine(function(a));
            Console.WriteLine(recursion(a, x));
            Console.ReadKey();
        }
    }
}
