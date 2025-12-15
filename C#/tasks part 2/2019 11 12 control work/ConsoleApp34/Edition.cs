using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace pr1211
{
    class Edition
    {
        protected string EditionName;
        protected DateTime ReleseDate;
        protected int PrintEdition;
        ArrayList MagazineEditorList = new ArrayList();
        ArrayList Magazine= new ArrayList();
        public Edition (string EditionName, DateTime ReleseDate, int PrintEdition)
        {
            this.EditionName = EditionName;
            this.ReleseDate = ReleseDate;
            this.PrintEdition_ = PrintEdition;
        }
        public Edition ()
        {
            this.EditionName = "Нет информации о названии издания";
            this.ReleseDate = new DateTime(2019,01,01);
            this.PrintEdition = 0;
        }
        public void FMagazineEditorsList(params Article[] a)
        {
            MagazineEditorList.AddRange(a);
        }
        public string EditionName_
        {
            get { return EditionName; }
            set { EditionName = value; }
        }
        public DateTime ReleseDate_
        {
            get { return ReleseDate; }
            set { ReleseDate = value; }
        }
        public virtual object DeepCopy()
        {
            Edition klon = new Edition(EditionName, ReleseDate, PrintEdition);
            return klon;
        }
        public int PrintEdition_
        {
            get { return PrintEdition; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Присваемое значение отрицательно!!!");
                else
                    PrintEdition = value;
            }
        }
        public virtual bool Equals(object obj)
        {
            Edition edition = (Edition)obj;
            if (EditionName == edition.EditionName && ReleseDate == edition.ReleseDate && PrintEdition == edition.PrintEdition)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return EditionName.GetHashCode() + ReleseDate.GetHashCode() + PrintEdition.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format("Название издания:{0}\n Дата выхода издания: {1},\n Тираж издания: {2}.\n", EditionName, ReleseDate, PrintEdition);
        }
    }
}
