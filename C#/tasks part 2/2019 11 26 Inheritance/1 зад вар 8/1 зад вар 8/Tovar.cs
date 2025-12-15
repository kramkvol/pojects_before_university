using System;

namespace _1_зад_вар_8
{
    abstract class Tovar
    {
        public string Tovar_name { set; get; }
        public Tovar()
        {
            Tovar_name = "Нет информации названии товара";
        }
        public Tovar (string TN)
        {
            Tovar_name = TN;
        }
        virtual public void Passport()
        {
            Console.WriteLine("Название товара: " + Tovar_name);
        }
    }
}
