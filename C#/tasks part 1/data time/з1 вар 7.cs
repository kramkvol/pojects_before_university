using System;

namespace ConsoleApp34
{
    public struct DataTime
    {
        static public DateTime t1;
        static public DateTime t2;
        static public TimeSpan timeSpan;
        static void Main(string[] args)
        {
            t1 = DateTime.Now;
            Console.WriteLine("Время сейчас: " + t1.TimeOfDay);
            t2 = DateTime.MaxValue;
            timeSpan = t2.TimeOfDay - t1.TimeOfDay;
            Console.WriteLine("Kоличество секунд, оставшихся до конца суток.: " + timeSpan.TotalSeconds);
            Console.ReadKey();
        }
    }
}
