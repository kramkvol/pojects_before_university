namespace ConsoleApp40
{
    class Serviceman : YangMan
    {
        YangMan PersonInf;
        string MilitatyDuty;
        public Serviceman(YangMan PersonInf, string MilitatyDuty)
        {
            this.PersonInf = PersonInf;
            this.MilitatyDuty = MilitatyDuty;
        }
        public Serviceman()
        {
            this.PersonInf = new YangMan();
            this.MilitatyDuty = "Военнослужащий";
        }
        public override string ToString()
        {
            return string.Format("\n \t Военнообязанность: {0}. \n \n", MilitatyDuty);
        }
    }
}
