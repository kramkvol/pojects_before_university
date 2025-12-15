namespace ConsoleApp40
{
    class Student : YangMan
    {
        YangMan PersonInf;
        string MilitatyDuty;
        public Student (YangMan PersonInf, string MilitatyDuty)
        {
            this.PersonInf = PersonInf;
            this.MilitatyDuty = MilitatyDuty;
        }
        public Student()
        {
            this.MilitatyDuty = "Нет военной обязанности.";
        }
        public override string ToString()
        {
            return string.Format("\n \t Военнообязанность: {0}\n\n ", MilitatyDuty);
        }
    }
}
