using System;
namespace _1_зад_вар_8
{
    abstract class Product
    {
        public string Otdel { set; get; }
        static int REALNumProduct;
        public Product()
        {
            Otdel = "Нет информации о отделе товара";
        }
        public Product(string OT)
        {
            Otdel = OT;
            REALNumProduct++;
        }

        virtual public void Passport()
        {
            Console.WriteLine("Отдел: " + Otdel);
        }
    }
}
