using System;
namespace _1_зад_вар_8
{
     class Radio_Tovar : Tovar
    {
        private string Naznachenie;
        static int ObjNum = 0;
        public Radio_Tovar(string TN, string naznach) : base(TN)
        {
            Naznachenie = naznach;
            ObjNum++;
        }
        public Radio_Tovar ()
        {
            Naznachenie = "радиотовары";
        }
        public string Tovar_naznachenie_Get_SeT
        {
            get { return Naznachenie; }
            set { Naznachenie = value; }
        }
        static public void Objects ()
        {
            Console.WriteLine($"Количество радиотоваров {ObjNum}");
        }
        override public void Passport()
        {
            Console.WriteLine("\nНазвание товара: " + Tovar_name + "\nНазначение: "+ Naznachenie);
        }
    }
}
