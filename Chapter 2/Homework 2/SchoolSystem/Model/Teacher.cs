namespace SchoolSystem.Model
{
    public class Teacher : Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Subject { get;set; }
        public Teacher(string name, string surname,string subject) 
        {
            Name = name;
            Surname = surname;
            Subject = subject;
        }

        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }

    }
}