using System;
using System.Collections.Generic;
namespace _3
{
    class Operator
    {
        public List<string> news;
        public string weather;
        public List<string> sport;
        public List<string> incident;
        public List<string> humor;
        public delegate void ADD();
        public event ADD Notify;
        public Operator(List<string> news_, string weather_, List<string> sport_, List<string> incident_, List<string> humor_)
        {
            news = news_;
            weather = weather_;
            sport = sport_;
            incident = incident_;
            humor = humor_;
        }
        public void AddNews(params string[] a)
        {
            news.AddRange(a);
            Notify?.Invoke();
        }
        public void AddSport(params string[] a)
        {
            sport.AddRange(a);
        }
        public void AddIncident(params string[] a)
        {
            incident.AddRange(a);
        }
        public void AddHumor(params string[] a)
        {
            humor.AddRange(a);
        }
        public void AddInf()
        {
            Console.WriteLine(" Выберите категорию, чтобы добавить информацию в рассылку");
            Console.WriteLine(" 1. Новости;\n 2. Спорт;\n 3. Инциденты; \n 4. Юмор. ");
            metka3:
            string buf2 = Console.ReadLine();
            int num2 = Convert.ToInt32(buf2);
            switch (num2)
            {
                case 1:
                    string str1 = Console.ReadLine();
                    AddNews(str1);
                    break;
                case 2:
                    string str2 = Console.ReadLine();
                    AddSport(str2);
                    break;
                case 3:
                    string str3 = Console.ReadLine();
                    AddIncident(str3);
                    break;
                case 4:
                    string str4 = Console.ReadLine();
                    AddHumor(str4);
                    break;
                default:
                    Console.WriteLine("Нет такой цифры. Попробуйте еще раз");
                    goto metka3;
            }
        }
    }
}
