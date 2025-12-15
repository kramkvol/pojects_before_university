using System;
namespace _1_зад_вар_8
{
    class MilkProduct : Product
    {
        public string Raznovidnost;
        public DateTime DataIzgotovleniya;
        public MilkProduct(string PR, string RV, DateTime DIZ) : base(PR)
        {
            Raznovidnost = RV;
            DataIzgotovleniya = DIZ;
        }
        public MilkProduct()
        {
            Raznovidnost = "молочный продукт";
            DataIzgotovleniya = DateTime.Now;
        }
        public string Prod_Razn_Get_SeT
        {
            get { return Raznovidnost; }
            set { Raznovidnost = value; }
        }
        public DateTime DataIZG_Get_SeT
        {
            get { return DataIzgotovleniya; }
            set { DataIzgotovleniya = value; }
        }

        override public void Passport()
        {
            Console.WriteLine("\nОтдел: " + Otdel + "\nРазновидность: " + Raznovidnost + "\nДата изготовления: " + DataIzgotovleniya);
        }
    } 
}
