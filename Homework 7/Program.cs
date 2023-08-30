namespace Homework_7
{
    class Program
    { 
        public static void Main(string[] args)
        {
            Student stu = new ("James","Clyde");
            Student stu2 = new("Walter","Hartwell White");
            Group group = new ("KOMOTO");
            Console.WriteLine(stu);
            Console.WriteLine(stu2);
            group.AddStudentToGroup(stu);
            group.AddStudentToGroup(stu2);
            //group.GetAllStudents();
            group.RemoveStudentFromGroup(1);
            group.GetAllStudents();
        }
    }
}