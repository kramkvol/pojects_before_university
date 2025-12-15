using System;
using System.Collections.Generic;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> AllNews = new List<string>();
            string AllWeather = "Сплошная облачность. Возможен мокрый снег.";
            List<string> AllSport = new List<string>();
            List<string> AllIncident = new List<string>();
            List<string> AllHumor = new List<string>();
            AllNews.Add("Новость1");
            AllNews.Add("Новость2");
            AllNews.Add("Новость3");
            AllSport.Add("Спорт1"); 
            AllIncident.Add("Инцидент 1");
            AllIncident.Add("Инцидент 2");
            AllHumor.Add("Юмор 1");
            AllHumor.Add("Юмор 2");
            Operator jen11012020 = new Operator(AllNews, AllWeather, AllSport, AllIncident,AllHumor);
            Subscriber a1 = new Subscriber(" Подписчик 1", AllNews, AllWeather, AllSport, AllIncident, AllHumor);
            Subscriber a2 = new Subscriber(" Подписчик 2", AllNews, AllWeather, AllSport, AllIncident, AllHumor);
            Subscriber a3 = new Subscriber(" Подписчик 3", AllNews, AllWeather, AllSport, AllIncident, AllHumor);
            a1.podpiska();
            Console.WriteLine("______________________");
            a2.podpiska();
            Console.WriteLine("______________________");
            a3.podpiska();
            Console.WriteLine("______________________");
            a1.rassilka();
            a2.rassilka();
            a3.rassilka();
            Console.WriteLine("______________________");
            jen11012020.AddInf();
            Console.WriteLine("______________________");
            Console.WriteLine("__ОБНОВЛЕННАЯ РАССЫЛКА!__");
            Console.WriteLine("______________________");
            a1.rassilka();
            jen11012020.Notify += a1.DisplayMessage;
            Console.WriteLine("______________________");
            jen11012020.AddInf();
            a1.rassilka();
            a1.Notify += a1.DisplayMessage;
            Console.WriteLine("______________________");
            a3.rassilka();
            a1.Notify += a1.DisplayMessage;
            Console.WriteLine("______________________");
            Console.ReadKey();
        }
    }
}
