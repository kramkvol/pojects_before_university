using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1211
{
    class Person 
    {
        string name;
        string surname;
        DateTime _DateOfBirth;

        public Person(string name, string surname, DateTime DateTime)
        {
            this.name = name;
            this.surname = surname;
            this._DateOfBirth = DateTime;
        }
        public Person()
        {
            this.name = "Нет данных о имени";
            this.surname = "Нет данных о фамилии";
            this._DateOfBirth =new DateTime(2019,01,01);
        }
        public string PName
        {
            get { return name; }
            set { name = value; }
        }
        public string PSurname
        {
            get { return surname; }
            set { surname = value; }
        }
        public System.DateTime PDayOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
        public int Info
        {
            get { return _DateOfBirth.Year; }
            set { _DateOfBirth = new DateTime(); }
        }

       

        public static bool operator ==(Person a, Person b)
        {
            return a.Equals(b);
        }
        public override bool Equals(object obj)
        {
            Person person = (Person)obj;
            if (this.name == person.name && this.surname == person.surname && this._DateOfBirth == person._DateOfBirth)
                return true;
            else
                return false;
        }
        public static bool operator !=(Person a, Person b)
        {
            return !a.Equals(b);
        }
        public override int GetHashCode()
        {      
            return name.GetHashCode() + surname.GetHashCode() + _DateOfBirth.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format(" Имя: {0} {3}, \n Фамилия: {1} {4}, \n Год рождения {2} {5}. \n", name, surname, Info, name.GetHashCode(),surname.GetHashCode(), _DateOfBirth.GetHashCode());
        }
        
        public string ToShortString()
        {
            return " Имя:" + name + "\n" + " Фамилия:" + surname;
        }
        public virtual object DeepCopy()
        {
            Person klon = new Person(name, surname, _DateOfBirth);
            return klon;
        }
        
    }
}