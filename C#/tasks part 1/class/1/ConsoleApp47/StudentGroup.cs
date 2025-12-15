using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime da1 = new DateTime(2002, 10, 23);
            DateTime da2 = new DateTime(2001, 8, 22);
            DateTime da3 = new DateTime(2002, 12, 4);
            DateTime da4 = new DateTime(2001, 10, 7);
            Student a1 = new Student("ИмяУ", "ФамилияО", da1);
            Student a2 = new Student("ИмяК", "ФамилияЛ", da2);
            Student a3 = new Student("ИмяA", "ФамилияЦ", da3);
            Student a4 = new Student("ИмяЩ", "ФамилияМ", da4);
            List<Student> all = new List<Student>{ a1, a2, a3, a4 };
            Console.WriteLine("Ведите номер опреции: ");
            Console.WriteLine("1 Сортировка студентов по имени");
            Console.WriteLine("2 Сортировка студентов по фамилии");
            Console.WriteLine("3 Сортировка студентов по дате рождения");
            Console.WriteLine("4 Поиск по критерию имя");
            Console.WriteLine("5 Поиск по критерию фамилия");
            Console.WriteLine("6 Поиск по критерию дата рождения");
            Console.WriteLine("7 Добавить студента");

            string buf = Console.ReadLine();
            int num = Convert.ToInt32(buf);
            switch (num)
            {
                case 1:
                    var sort_name = from u1 in all
                                orderby u1.name
                                select u1;
                    foreach (Student u1 in sort_name)
                    {
                        u1.all_inf();
                    }
                    break;
                case 2:
                    var sort_surname = from u1 in all
                                    orderby u1.surname
                                    select u1;
                    foreach (Student u1 in sort_surname)
                    {
                        u1.all_inf();
                    }
                    break;
                case 3:
                    var sort_date = from u1 in all
                                    orderby u1.DayOfBirth
                                    select u1;
                    foreach (Student u1 in sort_date)
                    {
                        u1.all_inf();
                    }
                    break;
                case 4:
                    Console.WriteLine("Введите имя: ");
                    string search_name =  Console.ReadLine();
                    Student stname = all.Find((x) => x.name == search_name);
                    try
                    {
                        stname.all_inf();
                    }
                    catch
                    {
                        Console.WriteLine("Нет такого имени!");
                    }
                    break;
                case 5:
                    Console.WriteLine("Введите фамилию: ");
                    string search_surname = Console.ReadLine();
                    Student stsurname = all.Find((x) => x.surname == search_surname);
                    try
                    {
                        stsurname.all_inf();
                    }
                    catch
                    {
                        Console.WriteLine("Нет такой фамилии!");
                    }
                    break;
                case 6:
                    Console.WriteLine("Введите дату рождения: ");
                    string search_date = Console.ReadLine();
                    DateTime dt = Convert.ToDateTime(search_date);
                    Student stdt = all.Find((x) => x.DayOfBirth == dt);
                    try
                    {
                        stdt.all_inf();
                    }
                    catch
                    {
                        Console.WriteLine("Нет такой даты рождения!");
                    }
                    break;
                case 7:
                    
                    break;
                default:
                    Console.WriteLine("Нет такого номера операции!");
                    break;
            }
                Console.WriteLine();
                Console.ReadKey();
        }
    }
}

