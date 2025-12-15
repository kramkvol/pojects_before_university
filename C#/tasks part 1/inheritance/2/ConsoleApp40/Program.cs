using System;
namespace ConsoleApp40
{
    class Program
    {
        static void Main()
        {
            YangMan a = new YangMan ("Имя1", "Фамилия1");
            Console.Write(a.ToString());
            YangMan s1 = new Student();
            if (s1 is Student) Console.Write(s1.ToString());

            YangMan b = new YangMan("Имя2", "Фамилия2");
            Console.Write(b.ToString());
            YangMan v1 = new Cadet();
            if (v1 is Cadet) Console.Write(v1.ToString());

            YangMan c = new YangMan("Имя3", "Фамилия3");
            Console.Write(c.ToString());
            YangMan c1 = new Serviceman();
            if (v1 is Cadet) Console.Write(c1.ToString());

            Console.ReadKey();
        }
    }
}
