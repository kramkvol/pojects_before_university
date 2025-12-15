namespace ConsoleApp40
{
    class Cadet : YangMan
    {
        YangMan PersonInf;
        string MilitatyDuty;
        public Cadet(YangMan PersonInf, string MilitatyDuty)
        {
            this.PersonInf = PersonInf;
            this.MilitatyDuty = MilitatyDuty;
        }
        public Cadet()
        {
            this.PersonInf = new YangMan();
            this.MilitatyDuty = "Курсант";
        }
        public override string ToString()
        {
            return string.Format("\n \t Военнообязанность: {0}. \n \n", MilitatyDuty);
        }
    }
}
