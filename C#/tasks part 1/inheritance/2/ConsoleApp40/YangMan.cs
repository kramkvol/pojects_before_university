namespace ConsoleApp40
{
    class YangMan 
    {
        public string name;
        public string surname;
        public YangMan(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public YangMan()
        {
            this.name = "Нет данных о имени";
            this.surname = "Нет данных о фамилии";
        }
        public string PName
        {
            get { return name; }
            set { name = value; }
        }
        public string PSurname
        {
            get { return surname; }
            set { surname = value; }
        }

        public override string ToString()
        {
            return string.Format(" Данные о молодом человеке: \n \t Имя: {0}; \n\t Фамилия: {1};", name, surname);
        }
    }
}
