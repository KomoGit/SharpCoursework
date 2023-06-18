namespace Homework_7
{
    class Group
    {
        private static int _id;
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public Student[]? Students = Array.Empty<Student>();

        public Group()
        {
            _id += 1;
            Id = _id;
        }

        public Group(string name):this()
        {
            Name = name;
        }
        public void AddStudentToGroup(Student stu)
        {
            Array.Resize(ref Students, Students!.Length + 1);
            Students[Students.Length - 1] = stu;
            Console.WriteLine($"Student {stu} has been added to group {Name}");
        }

        public void RemoveStudentFromGroup(int id)
        {
            Student[] newStudents = Array.Empty<Student>();
            foreach (Student item in Students!)
            {
                if(item.Id != id)
                {
                    Array.Resize(ref newStudents, newStudents.Length + 1);
                    newStudents[newStudents.Length - 1] = item;
                }
            }
            Students = newStudents;
        }

        public void GetAllStudents()
        {
            if(Students!.Length == 0)
            {
                throw new Exception("No students regitered in this group.");
            }
            foreach (Student item in Students)
            {
                Console.WriteLine(item);
            }
        }
        public string GetStudentById(int Id)
        {
            if (Students!.Length != 0)
            {
                foreach (Student item in Students)
                {
                    if (item.Id == Id)
                    {
                        return item.ToString();
                    }
                }
            }
            throw new Exception($"Student by {Id} could not be found!");
        }
    }
}
