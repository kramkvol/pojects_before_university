using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Subscriber : Operator
    {
        public string name;
        public string result;
        public void DisplayMessage()
        {
            Console.WriteLine("ОБНОВЛЕНИЕ: ");
        }
        public Subscriber(string name_, List<string> news_, string weather_, List<string> sport_, List<string> incident_, List<string> humor_) : base(news_, weather_, sport_, incident_, humor_)
        {
            name = name_;
        }
        public string podpiska()
        {
            Console.WriteLine(" Выберите подписку для {0} (цифра): ", name);
            Console.WriteLine(" 1. Новости;\n 2. Погода;\n 3. Спорт;\n 4. Инциденты; \n 5. Юмор. ");
            metka:
            string num = Console.ReadLine();
            int num_ = Convert.ToInt32(num);
            switch (num_)
            {
                case 1:
                    result = "news";
                    return "news";
                case 2:
                    result = "weather";
                    return "weather";
                case 3:
                    result = "sport";
                    return "sport";
                case 4:
                    result = "incident";
                    return "incident";
                case 5:
                    result = "humor";
                    return "humor";
                default:
                    Console.WriteLine("Нет такой цифры. Попробуйте еще раз");
                    goto metka;
            }
        }
        public void rassilka()
        {
            Console.WriteLine(" Подписки {0}: ", name);
            switch (result)
            {
                case "news":
                    foreach (string n in news)
                    {
                        Console.WriteLine(n);
                    }
                    break;
                case "weather":
                    Console.WriteLine(weather);
                    break;
                case "sport":
                    foreach (string n in sport)
                    {
                        Console.WriteLine(n);
                    }
                    break;
                case "incident":
                    foreach (string n in incident)
                    {
                        Console.WriteLine(n);
                    }
                    break;
                case "humor":
                    foreach (string n in humor)
                    {
                        Console.WriteLine(n);
                    }
                    break;
            }
        }
    }
}
