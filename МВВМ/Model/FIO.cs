namespace WpfApp7
{
    public class FIO
    {
        public FIO(string surname, string name, string middleName)
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
        }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }

    }
}