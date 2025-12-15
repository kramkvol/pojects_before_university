using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1211
{
    class Article : IRateAndCopy
    {
        public Person AuthorArticteInf { get; set; }
        public string ArticleName { get; set; }
        public double reting { get; set; }

        public double Rating => throw new NotImplementedException();

        double IRateAndCopy.Rating => throw new NotImplementedException();

        public Article(Person AAI, string AN, double reting)
        {
            this.AuthorArticteInf = AAI;
            this.ArticleName = AN;
            this.reting = reting;
        }
        public Article()
        {
            this.AuthorArticteInf = new Person();
            this.ArticleName = "Нет информации";
            this.reting = 0;
        }
        public virtual object DeepCopy()
        {
            Article klon = new Article(AuthorArticteInf, ArticleName, reting);
            return klon;
        }
        public override string ToString()
        {
            return string.Format(" Данные автора статьи:\n{0} Название статьи: {1},\n Рейтинг: {2}.\n", AuthorArticteInf, ArticleName, reting);
        }

        object IRateAndCopy.DeepCopy()
        {
            Article klon = new Article(AuthorArticteInf, ArticleName+"IDC", reting);
            return klon;
        }
    }
}
