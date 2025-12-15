using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class ClassBankomatPrior : Bankomat, PriorBankomat
    {
        string BankomatAdress;
        string[] bonus = { "бонус1", "бонус2", "бонус3" };
        public void adress()
        {
            Console.Write("Введите адрес бакомата: ");
            BankomatAdress = Console.ReadLine();
        }
        public string get_bonus()
        {
            Random rand = new Random();
            int n = rand.Next(0,2);
            return bonus[n];
        }
        public void TakeMoney()
        {
            Console.WriteLine("Введите нужную сумму: ");
            string buf = Console.ReadLine();
            double money = Convert.ToDouble(buf);
        }
    }
}
