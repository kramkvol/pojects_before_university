using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_зад_вар_8
{
    class Program 
    {
        static void Main(string[] args)
        {
            Tovar a1 = new Radio_Tovar("Товар 1", "радиотовар");
            if (a1 is Radio_Tovar) ((Radio_Tovar)a1).Passport();
            Tovar a2 = new Radio_Tovar("Товар 2", "радиотовар2");
            if (a2 is Radio_Tovar) ((Radio_Tovar)a2).Passport();
            Console.Write("***********************");
            DateTime dt1 = new DateTime(2019, 12, 12, 14, 33, 23);
            Product b1 = new MilkProduct("Молочный продукт ", "Молоко", dt1);
            if (b1 is MilkProduct) ((MilkProduct)b1).Passport();
            DateTime dt2 = new DateTime(2019, 12, 15, 12, 16, 50);
            Product b2 = new MilkProduct("Молочный продукт ", "Сметана", dt2);
            if (b2 is MilkProduct) ((MilkProduct)b2).Passport();
            Console.WriteLine ("***********************");
            HairDryer h1 = new HairDryer();
            h1.HairDryerToUSe();
            Radio_Tovar.Objects();
            //Console.WriteLine("Задайте нужное число продуктов: ");
            //string buf = Console.ReadLine();
            //int a = Convert.ToInt32(buf);
            //Console.WriteLine(Product.FNumProduct(ref a));
            Console.ReadKey();
        }
    }
}
