using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pr1211
{
    class Magazine : Edition
    {
        enum Frequency
        {
            Weekly,
            Monthly,
            Yearly
        }
        Frequency FrequencyOfRelis;
        
        protected ArrayList MagazineEditorList=new ArrayList();
        protected ArrayList ListOFArticles = new ArrayList();

        Magazine(string MagazineName, Frequency FrequencyOfRelis, DateTime RelissDate, int Edition) : base(MagazineName,RelissDate,Edition)
        { 
            this.FrequencyOfRelis = FrequencyOfRelis;         
        }

        public Magazine():base()
        {   
            this.FrequencyOfRelis = Frequency.Yearly;        
        }
        Frequency FRelise
        {
            get { return FrequencyOfRelis; }
            set { FrequencyOfRelis = value; }
        }

        double Average
        {
            get
            {
                double retng = 0;
                foreach (var a in ListOFArticles)
                {
                    retng += (a as Article).Rating;
                }
                return retng / ListOFArticles.Capacity;
            }
        }       
        public ArrayList ArticleList 
        {
            get { return ListOFArticles; } 
            set { ListOFArticles = value; }
        }
        public ArrayList MagazinEditorlist 
        {
            get { return MagazinEditorlist; }
        }
        public void FAddArticles (params Article[] a )
        {
            ListOFArticles.AddRange(a);
        }
        public override object DeepCopy()
        {
            Magazine klon = new Magazine(EditionName, FrequencyOfRelis, ReleseDate, PrintEdition);
            return klon;
        }
        public Edition s
        {
            get
            {
                Edition obj = new Edition(EditionName, ReleseDate,PrintEdition);
                return obj;
            }
        }
        public override string ToString()
        {
            string a = string.Empty;
            for (int i = 0; i < ListOFArticles.Count; i++)
            {
                a += (ListOFArticles[i] as Article).ToString() + "##\n-------\n";
            }
            Console.WriteLine("****************************");
            string aa = string.Empty;
            for (int i = 0; i < MagazineEditorList.Count; i++)
            {
                aa += (MagazineEditorList[i] as Person) + "!!!!\n-------\n";
            }
            return string.Format("\n {3} Частота выхода:{0}," +
                "\n Список статей:{1}, \n Список редакторов {2}",
                  FrequencyOfRelis, a, aa, base.ToString()
                );
        }
        public string ToShortString()
        {
            return
                base.ToString() +
                " Частота выхода:" + FrequencyOfRelis + "\n" +
                "Средний рейтинг статей:" + Average + "\n"; 
        }
    }
}
