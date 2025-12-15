using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Student
    {
        public string name;
        public string surname;
        public DateTime DayOfBirth;
        int count = 0;
        public Student ()
        {
            name = "Нет информации о имени";
            surname = "Нет информации о фамилии";
            DayOfBirth = DateTime.Now;
        }
        public Student (string name_,string surname_, DateTime DayOfBirth_)
        {
            name = name_;
            surname = surname_;
            DayOfBirth = DayOfBirth_;
            count++;
        }
        public string GetNAme()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public DateTime GetDayOfBirth()
        {
            return DayOfBirth;
        }
        public void inf()
        {
            Console.WriteLine("Всего студентов: " + count);
        }

        public void all_inf ()
        {
            Console.WriteLine("Имя: {0};\nФамилия: {1};\nДата Рождения: {2}.", name, surname, DayOfBirth);
        }

    }
}
