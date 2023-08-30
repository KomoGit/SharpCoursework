namespace Homework_7
{
    class Student
    {
        private static int _id;
        public int Id { get; private set; }
        public string? Name;
        public string? Surname;

        public Student()
        {
            _id += 1;
            Id = _id;   
        }

        public Student(string name,string surname):this()
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Surname}";
        }
    }
}
