using System;
namespace pr1211
{
    public class Program
    {

        public static void Main()
        {
            DateTime dt1 = new DateTime(2019,10,13);
            Edition a1 = new Edition("Издание1", dt1, 200);
            Console.WriteLine(a1);
            Console.WriteLine("значение хэш - кода: " + a1.GetHashCode());
            Edition a2 = new Edition("Издание1", dt1, 200);
            Console.WriteLine(a2);
            Console.WriteLine("значение хэш - кода: " + a2.GetHashCode()); ;
            Console.WriteLine("ссылки на объекты не равны " + (a1 ==a2 ));
            Console.WriteLine("объекты равны " + a1.Equals(a2));
            Console.WriteLine("Введите тираж издания: ");

            DateTime dp3;
            dp3 = new DateTime(2019, 09, 20);
            Person p3 = new Person("Автор_нейм", "Автор_сорнэйм", dp3);
            try
            {
                Edition e = new Edition("trala;la", DateTime.Now, -9);
                Console.WriteLine(e);
                e.PrintEdition_ = 0;
            }
            catch (DivideByZeroException v) { Console.WriteLine(v.Message); }
            catch (ArgumentException v) { Console.WriteLine(v.Message); }

            DateTime pdt1 = new DateTime(1990, 09, 20);
            DateTime pdt2 = new DateTime(1995, 05, 07);
            DateTime pdt3 = new DateTime(1991, 02, 08);
            Person p1 = new Person("Имя1", " Фамилия1", pdt1);
            Person p2 = new Person("Имя2", " Фамилия2", pdt2);
            Magazine m = new Magazine();
            m.FAddArticles(new Article(p1, "Мышки", 4), new Article(p2, "Кролики", 10.0), new Article(p3, "Статья_нейм", 7.4));

            Console.WriteLine("***\n" + m);
            Edition m1 = (Edition)m.DeepCopy();
            Console.WriteLine(m);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(m1);
            // //DateTime d;
            // //d = new DateTime(2019, 09, 20);
            // //string[] Article = { "Статья 1", "Статья 2", "Статья 3", "Статья 3" };
            // ////Console.WriteLine("\n ToString()");
            // ////if (p is Person) Console.Write(((Person)p).ToString() + "\n");
            // ////Console.WriteLine(" ToShortString()");
            // ////if (p is Person) Console.Write(((Person)p).ToShortString());

            // ////Article a = new Article(p, "Статья_нейм", 6.9);
            // ////Console.WriteLine(" ToString()\n ");
            // ////if (a is Article && p is Person) Console.Write(((Article)a).ToString() + "\n");

            // ////if (a is Article && p is Person) Console.Write(((Article)a).ToString() + "\n");
            // //Magazine TheSun = new Magazine("The Sun", Frequency.Weekly, d, 120);
            // //Console.WriteLine(TheSun[Frequency.Weekly]);
            // //Console.WriteLine(" ToShortString()");
            // //if (TheSun is Magazine) Console.Write(((Magazine)TheSun).ToString());
            // Console.WriteLine("++++++++");
            // Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}